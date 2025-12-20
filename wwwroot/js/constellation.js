/**
 * Constellation Navigation
 * Renders a radial network graph where the active node moves to the center.
 */

class ConstellationNav {
    constructor(canvasId, data) {
        this.canvas = document.getElementById(canvasId);
        this.ctx = this.canvas.getContext('2d');
        this.data = data;
        
        // State
        this.currentNode = this.data; // Start at root
        this.nodes = []; // Flat list of currently visible nodes for rendering
        this.stars = []; // Background stars
        
        // Configuration
        this.config = {
            centerRadius: 150, // Distance of children from center
            nodeRadius: 30, // Radius of the clickable circles
            transitionSpeed: 0.1, // Lerp factor (0-1)
            starCount: 150
        };

        // Resize handling
        window.addEventListener('resize', () => this.resize());
        this.resize();

        // Input handling
        this.canvas.addEventListener('click', (e) => this.handleClick(e));
        this.canvas.addEventListener('mousemove', (e) => this.handleHover(e));
        
        // Initialize
        this.initStars();
        this.updateLayout(this.currentNode); // Initial layout
        this.animate();
    }

    resize() {
        this.canvas.width = window.innerWidth;
        this.canvas.height = window.innerHeight;
        this.centerX = this.canvas.width / 2;
        this.centerY = this.canvas.height / 2;
        
        // Adjust radius for mobile
        if (this.canvas.width < 600) {
            this.config.centerRadius = this.canvas.width * 0.35;
            this.config.nodeRadius = 20;
        } else {
            this.config.centerRadius = 150;
            this.config.nodeRadius = 30;
        }
    }

    initStars() {
        this.stars = [];
        for (let i = 0; i < this.config.starCount; i++) {
            this.stars.push({
                x: Math.random() * this.canvas.width,
                y: Math.random() * this.canvas.height,
                size: Math.random() * 2,
                alpha: Math.random(),
                twinkleSpeed: Math.random() * 0.005 + 0.0005, // Slower twinkle (was 0.05)
                driftX: (Math.random() - 0.5) * 0.05, // Slower drift (was 0.2)
                driftY: (Math.random() - 0.5) * 0.05
            });
        }
    }

    // Convert hierarchical data to flat renderable nodes with target positions
    updateLayout(activeNode) {
        // We reuse existing node objects if they exist to preserve current positions for animation
        const newTargets = [];

        // 1. Center Node (Active)
        this.setTarget(activeNode, this.centerX, this.centerY, 'center');
        newTargets.push(activeNode);

        // 2. Children & Parent (Radial distribution)
        // Combine children and parent into one list for layout if parent exists
        let radialNodes = activeNode.children ? [...activeNode.children] : [];
        if (activeNode.parent) {
            radialNodes.push(activeNode.parent);
        }

        if (radialNodes.length > 0) {
            const count = radialNodes.length;
            // Add a random offset to the rotation to avoid perfect 90 degree alignments every time
            const randomOffset = Math.random() * Math.PI * 2; 
            const angleStep = (Math.PI * 2) / count;
            
            radialNodes.forEach((node, index) => {
                // Distribute evenly but rotated randomly
                const angle = index * angleStep + randomOffset; 
                
                // Add slight randomness to the radius for organic feel
                const radiusVariation = (Math.random() * 20) - 10; 
                const radius = this.config.centerRadius + radiusVariation;

                const tx = this.centerX + Math.cos(angle) * radius;
                const ty = this.centerY + Math.sin(angle) * radius;
                
                // Identify type
                const type = (node === activeNode.parent) ? 'parent' : 'child';
                this.setTarget(node, tx, ty, type);
                newTargets.push(node);
            });
        }

        // Update the main list
        this.nodes = newTargets;
    }

    setTarget(node, x, y, type) {
        // If node doesn't have current pos (first appear), spawn it at center or parent pos
        if (typeof node.x === 'undefined') {
            node.x = this.centerX;
            node.y = this.centerY;
        }
        node.targetX = x;
        node.targetY = y;
        node.type = type;
        node.hovered = false;
    }

    animate() {
        this.ctx.fillStyle = '#050505';
        this.ctx.fillRect(0, 0, this.canvas.width, this.canvas.height);

        this.drawStars();
        this.drawConnections();
        this.drawNodes();
        
        // Update positions
        let animating = false;
        this.nodes.forEach(node => {
            const dx = node.targetX - node.x;
            const dy = node.targetY - node.y;
            
            if (Math.abs(dx) > 0.5 || Math.abs(dy) > 0.5) {
                node.x += dx * this.config.transitionSpeed;
                node.y += dy * this.config.transitionSpeed;
                animating = true;
            } else {
                node.x = node.targetX;
                node.y = node.targetY;
            }
        });

        requestAnimationFrame(() => this.animate());
    }

    drawStars() {
        this.ctx.fillStyle = 'white';
        this.stars.forEach(star => {
            // Twinkle effect
            star.alpha += star.twinkleSpeed;
            if (star.alpha > 1 || star.alpha < 0.2) {
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

            this.ctx.globalAlpha = Math.max(0, Math.min(1, star.alpha));
            this.ctx.beginPath();
            this.ctx.arc(star.x, star.y, star.size, 0, Math.PI * 2);
            this.ctx.fill();
        });
        this.ctx.globalAlpha = 1.0;
    }

    drawConnections() {
        this.ctx.strokeStyle = 'rgba(100, 100, 255, 0.2)';
        this.ctx.lineWidth = 1;
        
        // Draw lines from center to children
        this.nodes.forEach(node => {
            if (node !== this.currentNode) {
                this.ctx.beginPath();
                this.ctx.moveTo(this.currentNode.x, this.currentNode.y);
                this.ctx.lineTo(node.x, node.y);
                this.ctx.stroke();
            }
        });
    }

    drawNodes() {
        // Time-based animation for nebula effect
        const time = Date.now() * 0.0005;

        this.nodes.forEach(node => {
            const radius = node === this.currentNode ? this.config.nodeRadius * 1.5 : this.config.nodeRadius;
            const cx = node.x;
            const cy = node.y;
            
            // Color selection
            // Home is always orange (id='home')
            // Parent/Back button is orange
            // Hovered is white/hot
            const isHome = node.id === 'home';
            const isParent = node.type === 'parent';
            const useOrange = isHome || isParent;
            
            let r, g, b;
            if (useOrange) {
                // Orange/Gold
                r = 255; g = 160; b = 40;
            } else {
                // Blue/Nebula
                r = 100; g = 140; b = 255;
            }

            if (node.hovered) {
                // Whiter when hovered
                r = 255; g = 255; b = 255;
            }

            // Save context for composite operations
            this.ctx.save();
            
            // Use additive blending for "light" effect
            this.ctx.globalCompositeOperation = 'screen'; 

            // 1. Inner Core (Bright)
            // Pulse the core size slightly
            // Offset core pulse by node index or position so they aren't in sync
            const nodeOffset = cx + cy; // Simple pseudo-random offset based on position
            const corePulse = 1 + Math.sin(time * 3 + nodeOffset) * 0.05; 
            const coreGradient = this.ctx.createRadialGradient(cx, cy, 0, cx, cy, radius * 0.8 * corePulse);
            coreGradient.addColorStop(0, '#ffffff');
            coreGradient.addColorStop(0.4, `rgba(${r}, ${g}, ${b}, 0.8)`);
            coreGradient.addColorStop(1, `rgba(${r}, ${g}, ${b}, 0)`);
            
            this.ctx.fillStyle = coreGradient;
            this.ctx.beginPath();
            this.ctx.arc(cx, cy, radius * corePulse, 0, Math.PI * 2);
            this.ctx.fill();

            // 2. Gaseous Layers (Smoke/Nebula)
            // Draw rotating distorted blobs to simulate smoke/gas
            const layers = 3;
            for(let i = 0; i < layers; i++) {
                // Calculate individual rotation and scale for this layer
                // Vary speeds: Outer layers rotate slower
                const speed = 0.2 + (i * 0.1);
                const direction = i % 2 === 0 ? 1 : -1; // Alternate direction
                const layerOffset = i * (Math.PI * 2 / layers);
                const rotation = time * speed * direction + layerOffset + nodeOffset; // Add nodeOffset
                
                // Pulsing distortion (Breathing)
                // Offset the pulse for each layer so they don't breathe in sync
                const pulseOffset = i * 2 + nodeOffset; // Add nodeOffset
                const scaleX = 1 + Math.sin(time * 2 + pulseOffset) * 0.15; // Increased amplitude
                const scaleY = 1 + Math.cos(time * 2.5 + pulseOffset) * 0.15;
                
                // Opacity Pulse
                const alphaPulse = 0.1 + Math.sin(time + i + nodeOffset) * 0.05; // Oscillate between 0.05 and 0.15

                this.ctx.save(); // Save again for transform
                this.ctx.translate(cx, cy);
                this.ctx.rotate(rotation);
                this.ctx.scale(scaleX, scaleY);
                
                const gasGradient = this.ctx.createRadialGradient(0, 0, radius * 0.4, 0, 0, radius * 2.0);
                gasGradient.addColorStop(0, `rgba(${r}, ${g}, ${b}, 0)`);
                gasGradient.addColorStop(0.4, `rgba(${r}, ${g}, ${b}, ${alphaPulse})`);
                gasGradient.addColorStop(1, `rgba(0, 0, 0, 0)`);
                
                this.ctx.fillStyle = gasGradient;
                this.ctx.beginPath();
                this.ctx.arc(0, 0, radius * 2.0, 0, Math.PI * 2);
                this.ctx.fill();
                
                this.ctx.restore();
            }

            this.ctx.restore();

            // Text Label
            this.ctx.fillStyle = '#e0e0e0';
            this.ctx.font = '14px Arial';
            this.ctx.textAlign = 'center';
            this.ctx.textBaseline = 'middle';
            
            const textY = node.y + radius + 30;
            this.ctx.fillText(node.label, node.x, textY);
        });
    }

    handleClick(e) {
        const rect = this.canvas.getBoundingClientRect();
        const x = e.clientX - rect.left;
        const y = e.clientY - rect.top;

        // Check clicks
        for (const node of this.nodes) {
            const radius = node === this.currentNode ? this.config.nodeRadius * 1.5 : this.config.nodeRadius;
            const dx = x - node.x;
            const dy = y - node.y;
            
            if (dx * dx + dy * dy < radius * radius) {
                if (node.url) {
                    window.location.href = node.url;
                } else {
                    this.navigateTo(node);
                }
                break;
            }
        }
    }

    handleHover(e) {
        const rect = this.canvas.getBoundingClientRect();
        const x = e.clientX - rect.left;
        const y = e.clientY - rect.top;
        
        let cursor = 'default';
        this.nodes.forEach(node => {
            const radius = node === this.currentNode ? this.config.nodeRadius * 1.5 : this.config.nodeRadius;
            const dx = x - node.x;
            const dy = y - node.y;
            const hit = dx * dx + dy * dy < radius * radius;
            
            if (hit) {
                cursor = 'pointer';
            }
            node.hovered = hit;
        });
        
        this.canvas.style.cursor = cursor;
    }

    navigateTo(node) {
        // Set parent relationship if moving down
        if (node !== this.currentNode.parent && !node.parent) {
            node.parent = this.currentNode;
        }
        this.currentNode = node;
        this.updateLayout(node);
    }
}

// Data Definition
const siteData = {
    id: "home", 
    label: "Home", 
    children: [
        { 
            id: "books", 
            label: "Books", 
            children: [
                { id: "asimov", label: "Isaac Asimov", url: "/Books/Asimov" },
                { id: "chiang", label: "Ted Chiang", url: "/Books/Chiang" },
                { id: "clarke", label: "Arthur C. Clarke", url: "/Books/Clarke" },
                { id: "heinlein", label: "Robert A. Heinlein", url: "/Books/Heinlein" },
                { id: "philosophy", label: "Philosophy", url: "/Philosophy" },
                { id: "tractatus", label: "Tractatus", url: "/Tractatus" },
            ]
        },
        { 
            id: "games", 
            label: "Games", 
            children: [
                { id: "games", label: "Games List", url: "/Games" },
                { id: "engines", label: "Engines List", url: "/Engines" },
                { id: "maps", label: "Maps List", url: "/Maps" },
                { id: "servers", label: "Server Browser", url: "/Servers" },
                { id: "ccgs", label: "CCGs", url: "/CCGs" },
            ]
        },
        {
            id: "website",
            label: "Website",
            children: [
                { id: "about", label: "About", url: "/About" },
                { id: "links", label: "Links", url: "/Links" },
                { id: "updates", label: "Updates", url: "/Updates" },
                { id: "years", label: "Years", url: "/Years" },
            ]
        }
    ]
};

// Start
document.addEventListener('DOMContentLoaded', () => {
    new ConstellationNav('constellation-canvas', siteData);
});
