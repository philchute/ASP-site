/**
 * Tron Light Cycle Trail Animation
 * Creates an animated grid background with neon light trails that move and turn
 * across the screen, inspired by the TRON movie aesthetic.
 */
document.addEventListener('DOMContentLoaded', () => {
    // Configuration
    const CONFIG = {
        gridSize: 100,        // Size of grid cells in pixels
        turnChance: 0.08,     // Probability of a trail turning (0-1)
        moveSpeed: 4,         // Pixels per frame the trail moves
        trailColors: ['blue', 'orange', 'green', 'purple'],
        trailDelay: {
            min: 8000,          // Minimum delay between trails
            max: 12000          // Maximum delay between trails
        }
    };

    // Cache DOM elements
    const container = document.querySelector('.tron-container');
    const menuItems = document.querySelectorAll('.menu-item');
    
    // Setup menu navigation
    menuItems.forEach(item => {
        item.addEventListener('click', () => {
            const page = item.textContent.toLowerCase();
            window.location.href = `/${page}`;
        });
    });

    // Create and setup trail container
    const trailContainer = document.createElement('div');
    trailContainer.className = 'light-trail-container';
    container.appendChild(trailContainer);

    // Store active trails
    const trails = [];
    let lastColorIndex = -1;

    /**
     * Creates a new trail segment element
     */
    function createTrailSegment(x, y, width, height, color, isHorizontal) {
        const segment = document.createElement('div');
        segment.className = `permanent-trail ${isHorizontal ? 'horizontal' : 'vertical'}`;
        segment.style.cssText = `
            left: ${x}px;
            top: ${y}px;
            width: ${width}px;
            height: ${height}px;
            color: var(--neon-${color});
            background: var(--neon-${color});
        `;
        trailContainer.appendChild(segment);
        return segment;
    }

    /**
     * Creates and animates a new light trail
     */
    function createLightTrail() {
        // Calculate starting position
        const minY = window.innerHeight * 0.1;
        const maxY = window.innerHeight * 0.9;
        const y = Math.round((Math.random() * (maxY - minY) + minY) / CONFIG.gridSize) * CONFIG.gridSize;

        // Cycle through colors
        lastColorIndex = (lastColorIndex + 1) % CONFIG.trailColors.length;
        const color = CONFIG.trailColors[lastColorIndex];

        // Initialize trail state
        const trail = {
            color,
            currentX: -100,
            currentY: y,
            segments: [],
            currentSegment: null,
            segmentStartX: -100,
            segmentStartY: y,
            lastTurnX: -Infinity
        };
        trails.push(trail);

        function updateTrail() {
            // Remove trail when it exits screen
            if (trail.currentX > window.innerWidth + 100) {
                setTimeout(() => {
                    trail.segments.forEach(segment => segment.remove());
                    const index = trails.indexOf(trail);
                    if (index > -1) trails.splice(index, 1);
                }, 4000);
                return;
            }

            const minDistanceBetweenTurns = window.innerWidth / 4;
            const canTurn = trail.currentX - trail.lastTurnX >= minDistanceBetweenTurns;

            // Handle trail turning
            if (canTurn && Math.random() < CONFIG.turnChance && trail.currentSegment) {
                const width = trail.currentX - trail.segmentStartX;
                trail.currentSegment.style.width = `${width}px`;

                const direction = trail.currentY > window.innerHeight / 2 ? -1 : 1;
                const verticalDistance = CONFIG.gridSize * 2;

                // Create vertical segment
                const verticalSegment = createTrailSegment(
                    trail.currentX,
                    direction === 1 ? trail.currentY - 1 : trail.currentY - verticalDistance,
                    3,
                    verticalDistance + 2,
                    color,
                    false
                );
                trail.segments.push(verticalSegment);

                // Update trail position after turn
                trail.currentY += direction * verticalDistance;
                trail.lastTurnX = trail.currentX;
                trail.segmentStartX = trail.currentX;
                trail.segmentStartY = trail.currentY;

                // Start new horizontal segment
                trail.currentSegment = createTrailSegment(
                    trail.segmentStartX,
                    trail.segmentStartY,
                    0,
                    3,
                    color,
                    true
                );
                trail.segments.push(trail.currentSegment);
            } else if (!trail.currentSegment) {
                // Create initial segment
                trail.currentSegment = createTrailSegment(
                    trail.currentX,
                    trail.currentY,
                    0,
                    3,
                    color,
                    true
                );
                trail.segments.push(trail.currentSegment);
            }

            // Move trail forward
            trail.currentX += CONFIG.moveSpeed;
            if (trail.currentSegment) {
                trail.currentSegment.style.width = `${trail.currentX - trail.segmentStartX}px`;
            }

            requestAnimationFrame(updateTrail);
        }

        requestAnimationFrame(updateTrail);
    }

    /**
     * Schedules creation of new trails at random intervals
     */
    function scheduleNextTrail() {
        const delay = Math.random() * (CONFIG.trailDelay.max - CONFIG.trailDelay.min) + CONFIG.trailDelay.min;
        setTimeout(() => {
            createLightTrail();
            scheduleNextTrail();
        }, delay);
    }

    // Start the animation
    createLightTrail();
    scheduleNextTrail();
});