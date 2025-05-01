// Wait for the page to load before running the code
document.addEventListener('DOMContentLoaded', () => {
    // Setup menu navigation
    const menuItems = document.querySelectorAll('.menu-item');
    menuItems.forEach(item => {
        item.addEventListener('click', () => {
            const page = item.textContent.toLowerCase();
            window.location.href = `/${page}`;
        });
    });

    // Create container for light trails
    const container = document.querySelector('.tron-container');
    const trailContainer = document.createElement('div');
    trailContainer.className = 'light-trail-container';
    container.appendChild(trailContainer);

    // Trail settings
    const colors = ['blue', 'orange', 'green', 'purple'];  // Available trail colors
    const trails = [];  // Store all active trails
    let currentColorIndex = 0;  // Track which color to use next

    // Create a single trail segment (either horizontal or vertical)
    function createSegment(x, y, width, height, color) {
        const segment = document.createElement('div');
        segment.className = 'permanent-trail';
        segment.style.left = `${x}px`;
        segment.style.top = `${y}px`;
        segment.style.width = `${width}px`;
        segment.style.height = `${height}px`;
        segment.style.color = `var(--neon-${color})`;
        segment.style.background = `var(--neon-${color})`;
        trailContainer.appendChild(segment);
        return segment;
    }

    // Create and animate a complete trail
    function createTrail() {
        // Start trail at random height in the middle 80% of the screen
        const y = Math.floor(Math.random() * (window.innerHeight * 0.8) + window.innerHeight * 0.1);
        const color = colors[currentColorIndex];
        currentColorIndex = (currentColorIndex + 1) % colors.length;

        let x = -100;  // Start off-screen to the left
        let segments = [];  // Store all segments of this trail
        let lastTurnX = -Infinity;  // Track where the last turn happened

        // Update trail position and create new segments
        function update() {
            // Remove trail if it goes off-screen to the right
            if (x > window.innerWidth + 100) {
                setTimeout(() => {
                    segments.forEach(segment => segment.remove());
                    const index = trails.indexOf(segments);
                    if (index > -1) trails.splice(index, 1);
                }, 15000);  // Keep trail visible for 15 seconds after it finishes
                return;
            }

            // Randomly turn up or down
            if (x - lastTurnX > window.innerWidth / 4 && Math.random() < 0.08) {
                const direction = y > window.innerHeight / 2 ? -1 : 1;  // Turn up if in bottom half, down if in top half
                const verticalDistance = 200;  // How far to turn
                
                // Create vertical segment for the turn
                const verticalSegment = createSegment(x, y, 3, verticalDistance, color);
                segments.push(verticalSegment);
                
                y += direction * verticalDistance;  // Update y position after turn
                lastTurnX = x;  // Mark where we turned
            }

            // Create horizontal segment
            const segment = createSegment(x, y, 4, 3, color);
            segments.push(segment);

            x += 4;  // Move trail forward
            requestAnimationFrame(update);  // Continue animation
        }

        trails.push(segments);
        requestAnimationFrame(update);
    }

    // Start creating trails with random delays
    function startTrails() {
        createTrail();
        // Create next trail after 8-12 seconds
        setTimeout(startTrails, Math.random() * 4000 + 8000);
    }

    // Start the first trail
    startTrails();
});