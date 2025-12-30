document.addEventListener("DOMContentLoaded", function() {
    drawConnections();
    window.addEventListener('resize', drawConnections);
});

function drawConnections() {
    const svg = document.getElementById('connections-layer');
    const container = document.querySelector('.evolution-graph-container');
    
    // Ensure elements exist before accessing
    if (!svg || !container) return;
    
    // Resize SVG to match scrollable content
    svg.setAttribute('width', container.scrollWidth);
    svg.setAttribute('height', container.scrollHeight);
    svg.innerHTML = ''; // Clear previous lines

    // Using the new class name evolution-graph-node
    const nodes = document.querySelectorAll('.evolution-graph-node');
    
    // Constellation Palette
    const palette = [
        "#648cff", // Nebula Blue
        "#bfa1ff", // Violet
        "#2aa198", // Teal
        "#ffa028", // Orange
        "#d33682", // Magenta
        "#859900", // Green
        "#268bd2", // Blue
        "#cb4b16", // Red-Orange
        "#6c71c4", // Violet-Blue
    ];

    // Assign a consistent color based on node ID
    function getColor(id) {
        let hash = 0;
        for (let i = 0; i < id.length; i++) {
            hash = id.charCodeAt(i) + ((hash << 5) - hash);
        }
        const index = Math.abs(hash) % palette.length;
        return palette[index];
    }

    nodes.forEach(node => {
        const parentIds = node.getAttribute('data-parents');
        const nodeId = node.id.replace('node-', '');
        
        if (!parentIds) return;
        
        const pList = parentIds.split(',').filter(p => p);
        
        // Use the node's own ID to determine its incoming line color
        // This makes all lines leading TO this node the same color, unique to this node.
        const lineColor = getColor(nodeId);

        pList.forEach(pid => {
            const parentNode = document.getElementById('node-' + pid);
            if (parentNode) {
                drawCurve(svg, parentNode, node, lineColor);
            }
        });
    });
}

function drawCurve(svg, startElem, endElem, color) {
    // Get coordinates relative to the SVG container
    const svgRect = svg.getBoundingClientRect();
    const startRect = startElem.getBoundingClientRect();
    const endRect = endElem.getBoundingClientRect();

    const x1 = startRect.left + startRect.width / 2 - svgRect.left;
    const y1 = startRect.bottom - svgRect.top;
    const x2 = endRect.left + endRect.width / 2 - svgRect.left;
    const y2 = endRect.top - svgRect.top;

    // Bezier curve control points
    const c1x = x1;
    const c1y = y1 + (y2 - y1) / 2;
    const c2x = x2;
    const c2y = y1 + (y2 - y1) / 2;

    const path = document.createElementNS("http://www.w3.org/2000/svg", "path");
    const d = `M ${x1} ${y1} C ${c1x} ${c1y}, ${c2x} ${c2y}, ${x2} ${y2}`;
    
    path.setAttribute("d", d);
    path.setAttribute("stroke", color); 
    path.setAttribute("stroke-width", "2");
    path.setAttribute("fill", "none");
    path.setAttribute("opacity", "0.6"); // Slight transparency for better layering
    
    svg.appendChild(path);
}
