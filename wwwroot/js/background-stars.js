/**
 * Background Stars
 * Renders a starfield behind the page content, fading out near the main content container.
 */

class BackgroundStars {
    constructor() {
        this.canvas = document.createElement('canvas');
        this.ctx = this.canvas.getContext('2d');
        
        // Setup canvas
        this.canvas.style.position = 'fixed';
        this.canvas.style.top = '0';
        this.canvas.style.left = '0';
        this.canvas.style.width = '100%';
        this.canvas.style.height = '100%';
        this.canvas.style.zIndex = '-1';
        this.canvas.style.pointerEvents = 'none'; // Click through
        document.body.appendChild(this.canvas);

        // Configuration
        this.config = {
            starCount: 150,
            fadeDistance: 100 // Distance from container edge where fade starts
        };
        
        this.stars = [];
        this.containerRect = null;

        // Resize handling
        window.addEventListener('resize', () => this.resize());
        this.resize();
        
        // Initialize
        this.initStars();
        this.animate();
    }

    resize() {
        this.canvas.width = window.innerWidth;
        this.canvas.height = window.innerHeight;
        this.updateContainerRect();
    }

    updateContainerRect() {
        const container = document.querySelector('.container main') || document.querySelector('.container');
        if (container) {
            this.containerRect = container.getBoundingClientRect();
        } else {
            this.containerRect = null;
        }
    }

    initStars() {
        this.stars = [];
        for (let i = 0; i < this.config.starCount; i++) {
            this.stars.push({
                x: Math.random() * this.canvas.width,
                y: Math.random() * this.canvas.height,
                size: Math.random() * 2,
                baseAlpha: Math.random(), // Store original alpha
                alpha: Math.random(),
                twinkleSpeed: Math.random() * 0.005 + 0.0005,
                driftX: (Math.random() - 0.5) * 0.05,
                driftY: (Math.random() - 0.5) * 0.05
            });
        }
    }

    getOpacityMultiplier(star) {
        if (!this.containerRect) return 1.0;

        const rect = this.containerRect;
        const pad = this.config.fadeDistance;

        // Check if inside the container box
        if (star.x >= rect.left && star.x <= rect.right &&
            star.y >= rect.top && star.y <= rect.bottom) {
            return 0.0; // Completely hidden inside text
        }

        // Calculate distance to the nearest edge
        // If it's "above" or "below" the box but within horizontal range
        let dist = Infinity;

        // Horizontal zones
        const inHorzRange = star.x >= rect.left && star.x <= rect.right;
        const inVertRange = star.y >= rect.top && star.y <= rect.bottom;

        if (inHorzRange) {
            // Above or below
            const distTop = Math.abs(star.y - rect.top);
            const distBottom = Math.abs(star.y - rect.bottom);
            dist = Math.min(distTop, distBottom);
        } else if (inVertRange) {
            // Left or right
            const distLeft = Math.abs(star.x - rect.left);
            const distRight = Math.abs(star.x - rect.right);
            dist = Math.min(distLeft, distRight);
        } else {
            // Corner zones - distance to nearest corner
            const dx = Math.min(Math.abs(star.x - rect.left), Math.abs(star.x - rect.right));
            const dy = Math.min(Math.abs(star.y - rect.top), Math.abs(star.y - rect.bottom));
            dist = Math.sqrt(dx*dx + dy*dy);
        }

        // Map distance to opacity (0 to 1)
        if (dist < pad) {
            return dist / pad;
        }
        return 1.0;
    }

    animate() {
        // Clear entire canvas
        this.ctx.clearRect(0, 0, this.canvas.width, this.canvas.height);

        // Update container rect (in case of dynamic content change, though expensive to do every frame, maybe throttle?)
        // For now, doing it every frame is fine for simple sites, but let's stick to resize updates + maybe a scroll check if sticky elements move? 
        // Actually, container is usually centered and static relative to viewport? 
        // No, .container is in flow. getBoundingClientRect is relative to viewport.
        // So scrolling changes the rect position! We must update it on scroll or every frame.
        this.updateContainerRect();

        this.ctx.fillStyle = 'white';
        
        this.stars.forEach(star => {
            // Twinkle effect
            star.baseAlpha += star.twinkleSpeed;
            if (star.baseAlpha > 1 || star.baseAlpha < 0.2) {
                star.twinkleSpeed = -star.twinkleSpeed;
            }
            
            // Drift effect
            star.x += star.driftX;
            star.y += star.driftY;
            
            // Wrap around screen
            if (star.x < 0) star.x = this.canvas.width;
            if (star.x > this.canvas.width) star.x = 0;
            if (star.y < 0) star.y = this.canvas.height;
            if (star.y > this.canvas.height) star.y = 0;

            // Calculate fade based on container position
            const fade = this.getOpacityMultiplier(star);

            if (fade > 0.01) {
                // Combine twinkle alpha with position fade
                // Clamp baseAlpha between 0 and 1
                const currentBase = Math.max(0, Math.min(1, star.baseAlpha));
                const finalAlpha = currentBase * fade;

                this.ctx.globalAlpha = finalAlpha;
                this.ctx.beginPath();
                this.ctx.arc(star.x, star.y, star.size, 0, Math.PI * 2);
                this.ctx.fill();
            }
        });
        this.ctx.globalAlpha = 1.0;

        requestAnimationFrame(() => this.animate());
    }
}

document.addEventListener('DOMContentLoaded', () => {
    new BackgroundStars();
});

