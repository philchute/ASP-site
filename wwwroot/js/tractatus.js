// tractatus-app.js React application

// Ensure React and ReactDOM are available (from CDN in Tractatus.cshtml)
const { useState, useEffect, StrictMode, useRef } = React;

// --- Global Configuration & Utilities ---

// Basic text sanitization function (can be replaced with a more robust one like DOMPurify if needed)
const sanitizeText = (text) => {
    if (typeof text !== 'string') return '';
    return text.replace(/<script.*?>.*?<\/script>/gi, ''); 
};

// --- Helper Functions (will likely grow) ---
function getPropositionById(id, propositions) {
    if (!id || !propositions) return null;
    for (const prop of propositions) {
        if (prop.id === id) return prop;
        if (prop.children && prop.children.length > 0) {
            const foundInChildren = getPropositionById(id, prop.children);
            if (foundInChildren) return foundInChildren;
        }
    }
    return null;
}

function getParentId(id) {
    const idAsString = String(id); 
    
    if (!idAsString || !idAsString.includes('.')) { 
        return null;
    }
    const lastDotIndex = idAsString.lastIndexOf('.'); 
    const parent = idAsString.substring(0, lastDotIndex);
    return parent;
}

function getNextSiblingId(id, propositions, parentId) {
    let parentNode = parentId ? getPropositionById(parentId, propositions) : { children: propositions };
    if (!parentNode || !parentNode.children) return null;

    const currentIndex = parentNode.children.findIndex(p => p.id === id);
    if (currentIndex !== -1 && currentIndex < parentNode.children.length - 1) {
        return parentNode.children[currentIndex + 1].id;
    }
    return null;
}

function getPreviousSiblingId(id, propositions, parentId) {
    let parentNode = parentId ? getPropositionById(parentId, propositions) : { children: propositions };
    if (!parentNode || !parentNode.children) return null;

    const currentIndex = parentNode.children.findIndex(p => p.id === id);
    if (currentIndex > 0) {
        return parentNode.children[currentIndex - 1].id;
    }
    return null;
}

// Finds the next proposition in reading order (depth-first)
function getNextPropositionReadingOrder(currentId, propositions) {
    if (!currentId || !propositions) return null;
    const flatOrder = [];
    function flatten(props) {
        for (const p of props) {
            flatOrder.push(p.id);
            if (p.children && p.children.length > 0) flatten(p.children);
        }
    }
    flatten(propositions);
    const currentIndex = flatOrder.indexOf(currentId);
    return currentIndex !== -1 && currentIndex < flatOrder.length - 1 ? flatOrder[currentIndex + 1] : null;
}

function getPreviousPropositionReadingOrder(currentId, propositions) {
    if (!currentId || !propositions) return null;
    const flatOrder = [];
    function flatten(props) {
        for (const p of props) {
            flatOrder.push(p.id);
            if (p.children && p.children.length > 0) flatten(p.children);
        }
    }
    flatten(propositions);
    const currentIndex = flatOrder.indexOf(currentId);
    return currentIndex > 0 ? flatOrder[currentIndex - 1] : null;
}


// --- React Components ---

// Navigation Bar Item Component
function NavBarItem({ proposition, onClick, isCurrentSelected, isAncestorPath }) {
    let className = 'nav-bar-item';
    if (isCurrentSelected) {
        className += ' active';
    } else if (isAncestorPath) {
        className += ' ancestor-path';
    }

    return (
        <div className={className} onClick={() => onClick(proposition.id)}>
            {proposition.id}
        </div>
    );
}

// Navigation Bar Component
function NavigationBar({ propositions, onPropositionSelect, currentPathIds, overallCurrentPropositionId }) {
    if (!propositions || propositions.length === 0) return null;

    return (
        <div className="nav-bar">
            {propositions.map(prop => (
                <NavBarItem
                    key={prop.id}
                    proposition={prop}
                    isCurrentSelected={overallCurrentPropositionId === prop.id}
                    isAncestorPath={currentPathIds.includes(prop.id)}
                    onClick={onPropositionSelect}
                />
            ))}
        </div>
    );
}

// Language Configuration Component
function LanguageConfiguration({ availableTranslations, selectedLanguages, onLanguageChange }) {
    // Group languages by Tier
    const languagesByTier = availableTranslations.reduce((acc, lang) => {
        const tier = lang.tier === null || lang.tier === undefined ? 'Other' : `Tier ${lang.tier}`;
        if (!acc[tier]) {
            acc[tier] = [];
        }
        acc[tier].push(lang);
        return acc;
    }, {});

    // Ensure consistent order of tiers (e.g., Tier 1, Tier 2, ..., Other)
    const sortedTiers = Object.keys(languagesByTier).sort((a, b) => {
        if (a === 'Other') return 1;
        if (b === 'Other') return -1;
        return parseInt(a.replace('Tier ', '')) - parseInt(b.replace('Tier ', ''));
    });

    const handleCheckboxChange = (languageKey) => {
        // The onLanguageChange function is expected to handle the logic
        // of adding or removing the languageKey from the selectedLanguages array.
        onLanguageChange(languageKey);
    };

    return (
        <div className="language-config">
            <strong>Display Languages:</strong>
            {sortedTiers.map(tierName => (
                <div key={tierName} className="language-tier-group">
                    {languagesByTier[tierName].map(lang => (
                        <label key={lang.languageKey}>
                            <input
                                type="checkbox"
                                value={lang.languageKey}
                                checked={selectedLanguages.includes(lang.languageKey)}
                                onChange={() => handleCheckboxChange(lang.languageKey)}
                            />
                            {lang.displayName}
                        </label>
                    ))}
                </div>
            ))}
        </div>
    );
}

// NEW COMPONENT for rendering text that might contain math
function TextWithMath({ text }) {
    const textRef = useRef(null);

    useEffect(() => {
        if (textRef.current) {
            // Set the raw HTML content that includes [math] tags
            textRef.current.innerHTML = text || ""; 

            // Now, tell KaTeX to render math within this specific element
            // Ensure KaTeX's renderMathInElement is available (it should be if scripts loaded)
            if (window.renderMathInElement) {
                renderMathInElement(textRef.current, {
                    delimiters: [
                        {left: "[math]", right: "[/math]", display: true}
                    ],
                    throwOnError: false // Don't halt rendering on a TeX error
                });
            }
        }
    }, [text]); // Re-run this effect if the text content changes

    if (text === null || typeof text === 'undefined') {
        return null; 
    }

    return <div ref={textRef} />;
}

// Content Pane Component
function ContentPane({ proposition, translations, selectedLanguages }) {
    if (!proposition) {
      return <div className="content-pane" style={{ textAlign: 'center', paddingTop: '20px' }}>Select a proposition to view its details.</div>;
    }

    const title = proposition.id === "Preface" ? "Preface" : `Proposition ${proposition.id}`;

    return (
        <div className={`content-pane`}>
            <h3>{title}</h3>

            {selectedLanguages.length === 0 && (
                <p style={{ textAlign: 'center', fontStyle: 'italic' }}>Select a language to display content.</p>
            )}

            {selectedLanguages.map(langKey => {
                const translationMeta = translations.availableTranslations.find(t => t.languageKey === langKey);
                const text = translations.translationsByLanguage[langKey]?.[proposition.id];

                let contentToRender;
                if (text !== null && typeof text !== 'undefined' && text.trim() !== '') {
                    const requiresKaTeX = /\[math\]/.test(text); // Check for the custom [math] tag
                    if (requiresKaTeX) {
                        contentToRender = <TextWithMath text={text} />;
                    } else {
                        contentToRender = <div className="proposition-text-content" dangerouslySetInnerHTML={{ __html: sanitizeText(text) }}></div>;
                    }
                } else {
                    contentToRender = <div className="proposition-text-content empty-text">{/* This is the empty box */}</div>;
                }

                return (
                    <div key={langKey} className="translation-section">
                        <h4>{translationMeta?.displayName || langKey}</h4>
                        {contentToRender}
                    </div>
                );
            })}
        </div>
    );
}

// Main Application Component
function TractatusApp({ initialPropositions, initialTranslations }) {
    // Initialize selectedLanguages based on IsDefaultInTier from props first
    const initialSelectedLangs = initialTranslations?.availableTranslations
        ?.filter(lang => lang.isDefaultInTier)
        ?.map(lang => lang.languageKey) || [];
    const [selectedLanguages, setSelectedLanguages] = useState(initialSelectedLangs);

    // Add missing state declarations
    const [navigationLevels, setNavigationLevels] = useState([]);
    const [currentAncestorPathIds, setCurrentAncestorPathIds] = useState([]);

    // Check for missing proposition data early
    if (!initialPropositions || initialPropositions.length === 0) {
        // Retain language configuration even on error, so user knows part of app is alive
        const handleLanguageToggleOnError = (languageKey) => {
            setSelectedLanguages(prev =>
                prev.includes(languageKey)
                    ? prev.filter(lang => lang !== languageKey)
                    : [...prev, languageKey]
            );
        };

        return (
            <StrictMode>
                <div className="tractatus-layout-wrapper">
                    <div className="main-column" style={{ justifyContent: 'flex-start', alignItems: 'center' }}>
                        {initialTranslations && initialTranslations.availableTranslations && (
                            <LanguageConfiguration
                                availableTranslations={initialTranslations.availableTranslations}
                                selectedLanguages={selectedLanguages} // Use state here
                                onLanguageChange={handleLanguageToggleOnError} // Use dedicated handler
                            />
                        )}
                        <div style={{ padding: '20px', textAlign: 'center', color: '#dc3545', backgroundColor: '#f8d7da', border: '1px solid #f5c6cb', borderRadius: '.25rem', marginTop: '20px' }}>
                            <strong>Error:</strong> No proposition data loaded or proposition list is empty.
                            Please check the server-side data source (e.g., 'structure.json').
                        </div>
                    </div>
                </div>
            </StrictMode>
        );
    }

    const [currentPropositionId, setCurrentPropositionId] = useState(initialPropositions[0]?.id || null);

    useEffect(() => {
        const newNavLevels = [];
        if (!currentPropositionId) {
            if (initialPropositions && initialPropositions.length > 0) {
                newNavLevels.push({
                    level: 0,
                    propositions: initialPropositions,
                    parentIdForBarItems: null,
                });
            }
            setNavigationLevels(newNavLevels);
            setCurrentAncestorPathIds([]);
            return;
        }

        const path = [];
        let tempId = currentPropositionId;
        while (tempId) {
            path.unshift(tempId);
            tempId = getParentId(tempId); // Relies on String(id) in getParentId
        }
        setCurrentAncestorPathIds(path.slice(0, -1));

        // Level 0: Always add the bar for root propositions
        if (initialPropositions && initialPropositions.length > 0) {
            newNavLevels.push({
                level: 0,
                propositions: initialPropositions,
                parentIdForBarItems: null, 
            });
        }

        // For each segment in the path, if it's a parent node, add a bar for its children.
        // The level of this children's bar will be one greater than the index of the parent segment in the path.
        path.forEach((segmentId, indexInPath) => {
            const parentNode = getPropositionById(segmentId, initialPropositions);
            if (parentNode && parentNode.children && parentNode.children.length > 0) {
                // Ensure a bar for this parent's children (identified by segmentId) hasn't already been added.
                // This is important if path segments could somehow lead to re-adding children of an earlier path segment.
                if (!newNavLevels.some(bar => bar.parentIdForBarItems === segmentId)) {
                    newNavLevels.push({
                        level: indexInPath + 1, 
                        propositions: parentNode.children,
                        parentIdForBarItems: segmentId, // The parent of items in THIS bar is the current segmentId
                    });
                }
            }
        });
        
        setNavigationLevels(newNavLevels);
    }, [currentPropositionId, initialPropositions]);

    const handlePropositionSelect = (id) => {
        setCurrentPropositionId(id);
    };

    const handleLanguageToggle = (languageKey) => {
        setSelectedLanguages(prev =>
            prev.includes(languageKey)
                ? prev.filter(lang => lang !== languageKey)
                : [...prev, languageKey]
        );
    };

    const handleNavigation = (type) => {
        let nextId = null;
        switch (type) {
            case 'prev-reading':
                nextId = getPreviousPropositionReadingOrder(currentPropositionId, initialPropositions);
                break;
            case 'next-reading':
                nextId = getNextPropositionReadingOrder(currentPropositionId, initialPropositions);
                break;
        }
        if (nextId) setCurrentPropositionId(nextId);
    };

    const currentPropositionDetails = currentPropositionId ? getPropositionById(currentPropositionId, initialPropositions) : null;

    // Button disabled states
    const isPrevDisabled = !getPreviousPropositionReadingOrder(currentPropositionDetails?.id, initialPropositions);
    const isNextDisabled = !getNextPropositionReadingOrder(currentPropositionDetails?.id, initialPropositions);

    return (
        <StrictMode>
            <div className="tractatus-layout-wrapper"> {/* New top-level layout wrapper */}
                <button 
                    className="side-nav-button prev-button" 
                    onClick={() => handleNavigation('prev-reading')} 
                    title="Previous proposition in reading order"
                    disabled={isPrevDisabled}
                >
                    &lt; {/* Left arrow */}
                </button>

                <div className="main-column"> {/* New main column for content */}
                    <LanguageConfiguration 
                        availableTranslations={initialTranslations.availableTranslations}
                        selectedLanguages={selectedLanguages}
                        onLanguageChange={handleLanguageToggle}
                    />
                    {navigationLevels.map(levelData => (
                        <NavigationBar
                            key={`${levelData.level}-${levelData.parentIdForBarItems || 'root'}`}
                            propositions={levelData.propositions}
                            onPropositionSelect={handlePropositionSelect}
                            currentPathIds={currentAncestorPathIds}
                            overallCurrentPropositionId={currentPropositionId}
                        />
                    ))}
                    <ContentPane 
                        proposition={currentPropositionDetails}
                        translations={initialTranslations} 
                        selectedLanguages={selectedLanguages}
                    />
                </div>

                <button 
                    className="side-nav-button next-button" 
                    onClick={() => handleNavigation('next-reading')} 
                    title="Next proposition in reading order"
                    disabled={isNextDisabled}
                >
                    &gt; {/* Right arrow */}
                </button>
            </div>
        </StrictMode>
    );
}

// Entry point: Render the React app into the DOM
const container = document.getElementById('tractatus-app-container');

if (container) {
    try {
        const root = ReactDOM.createRoot(container);
        const tractatusData = window.tractatusData;
        const translationsData = window.translationsData;

        // It's crucial that tractatusData and translationsData are at least empty arrays/objects
        // if they are expected by the TractatusApp, to avoid errors within the app before
        // its own internal checks can run.

        if (typeof tractatusData !== 'undefined' && typeof translationsData !== 'undefined') {
            // Ensure they are not null if the app expects objects/arrays
            const propositions = tractatusData === null ? [] : tractatusData;
            const translations = translationsData === null ? { availableTranslations: [], translationsByLanguage: {} } : translationsData;

            root.render(
                <TractatusApp 
                    initialPropositions={propositions} 
                    initialTranslations={translations} 
                />
            );
        } else {
            let missingDataError = "Error: Essential data is missing.";
            if (typeof tractatusData === 'undefined') {
                missingDataError += " 'tractatusData' is not defined.";
            }
            if (typeof translationsData === 'undefined') {
                missingDataError += " 'translationsData' is not defined.";
            }
            console.error(missingDataError);
            container.innerHTML = `<div style="color: red; padding: 20px; text-align: center; border: 1px solid red;">${missingDataError} Please check console and C# backend.</div>`;
        }
    } catch (e) {
        console.error("Error rendering TractatusApp:", e);
        container.innerHTML = `<div style="color: red; padding: 20px; text-align: center; border: 1px solid red;">Critical error rendering application: ${e.message}. See console for details.</div>`;
    }
} else {
    console.error("Error: tractatus-app-container not found in the DOM.");
    // Attempt to display an error message in the body if the container is missing
    const body = document.body;
    if (body) {
        const errorDiv = document.createElement('div');
        errorDiv.style.color = 'red';
        errorDiv.style.padding = '20px';
        errorDiv.style.textAlign = 'center';
        errorDiv.style.border = '1px solid red';
        errorDiv.textContent = "Error: The application container ('tractatus-app-container') was not found in the HTML. Cannot render the application.";
        body.insertBefore(errorDiv, body.firstChild); // Prepend to body
    }
} 