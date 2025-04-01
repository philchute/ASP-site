document.addEventListener('DOMContentLoaded', () => {
    const menuItems = document.querySelectorAll('.menu-item');
    const container = document.querySelector('.tron-container');
    
    // Add click handlers for navigation
    menuItems.forEach(item => {
        item.addEventListener('click', () => {
            const page = item.textContent.toLowerCase();
            window.location.href = `/${page}`;
        });
    });

    // Create trail container
    const trailContainer = document.createElement('div');
    trailContainer.className = 'light-trail-container';
    container.appendChild(trailContainer);

    // Store existing trails and their segments
    const trails = [];
    const trailSpacing = 150;
    const gridSize = 100;
    const turnChance = 0.08;
    const moveSpeed = 4;

    // Available colors for trails
    const cycleColors = ['blue', 'orange', 'green', 'purple'];
    let lastColorIndex = -1;

    // Create a new trail segment
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

    // Create and animate a light trail
    function createLightTrail() {
        const minY = window.innerHeight * 0.1;
        const maxY = window.innerHeight * 0.9;
        const y = Math.round((Math.random() * (maxY - minY) + minY) / gridSize) * gridSize;

        // Cycle through colors
        lastColorIndex = (lastColorIndex + 1) % cycleColors.length;
        const color = cycleColors[lastColorIndex];

        let currentX = -100;
        let currentY = y;
        let currentSegment = null;
        let segmentStartX = currentX;
        let segmentStartY = currentY;
        let lastTurnX = -Infinity;

        const trail = {
            color,
            currentX,
            currentY,
            segments: []
        };
        trails.push(trail);

        function updateTrail() {
            if (currentX > window.innerWidth + 100) {
                setTimeout(() => {
                    trail.segments.forEach(segment => segment.remove());
                    const index = trails.indexOf(trail);
                    if (index > -1) trails.splice(index, 1);
                }, 4000);
                return;
            }

            const minDistanceBetweenTurns = window.innerWidth / 4;
            const canTurn = currentX - lastTurnX >= minDistanceBetweenTurns;

            if (canTurn && Math.random() < turnChance && currentSegment) {
                const width = currentX - segmentStartX;
                currentSegment.style.width = `${width}px`;

                const direction = currentY > window.innerHeight / 2 ? -1 : 1;
                const verticalDistance = gridSize * 2;

                const verticalSegment = createTrailSegment(
                    currentX,
                    direction === 1 ? currentY : currentY - verticalDistance,
                    3,
                    verticalDistance,
                    color,
                    false
                );
                trail.segments.push(verticalSegment);

                currentY += direction * verticalDistance;
                lastTurnX = currentX;

                segmentStartX = currentX;
                segmentStartY = currentY;
                currentSegment = createTrailSegment(
                    segmentStartX,
                    segmentStartY,
                    0,
                    3,
                    color,
                    true
                );
                trail.segments.push(currentSegment);
            } else if (!currentSegment) {
                currentSegment = createTrailSegment(
                    currentX,
                    currentY,
                    0,
                    3,
                    color,
                    true
                );
                trail.segments.push(currentSegment);
            }

            currentX += moveSpeed;

            if (currentSegment) {
                currentSegment.style.width = `${currentX - segmentStartX}px`;
            }

            trail.currentX = currentX;
            trail.currentY = currentY;

            requestAnimationFrame(updateTrail);
        }

        requestAnimationFrame(updateTrail);
    }

    // Create light trails periodically
    function scheduleNextTrail() {
        const minDelay = 8000;
        const maxDelay = 12000;
        const delay = Math.random() * (maxDelay - minDelay) + minDelay;
        
        setTimeout(() => {
            createLightTrail();
            scheduleNextTrail();
        }, delay);
    }

    // Start creating trails
    createLightTrail();
    scheduleNextTrail();
}); 