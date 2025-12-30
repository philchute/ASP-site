// chess-animations.js

class ChessMoveAnimator {
    constructor() {
        this.boardElements = document.querySelectorAll('.chess-board.large');
        if (!this.boardElements.length) return;

        // Store active intervals to clean up if needed
        this.intervals = [];
        
        // Initialize animations for each board found
        this.boardElements.forEach(board => this.initBoard(board));
    }

    initBoard(board) {
        // Read animation frames from data attribute
        const framesData = board.dataset.animationFrames;
        if (!framesData) return;

        let frames = [];
        try {
            frames = JSON.parse(framesData);
        } catch (e) {
            console.error("Failed to parse animation frames", e);
            return;
        }

        // If no frames or only 1 frame, no animation needed
        if (!frames || frames.length <= 1) return;

        let currentFrameIndex = 0;
        
        // Initial render is already handled by server-side HTML for frame 0 (usually)
        // But let's start the loop.
        
        const intervalId = setInterval(() => {
            currentFrameIndex = (currentFrameIndex + 1) % frames.length;
            this.renderFrame(board, frames[currentFrameIndex]);
        }, 1200); // 1.2s per frame

        this.intervals.push(intervalId);
    }

    renderFrame(board, frame) {
        // frame = { targets: [{r, f, style}], hurdles: [{r, f}] }
        
        // 1. Clear dynamic elements
        const allSquares = board.querySelectorAll('.square');
        allSquares.forEach(sq => {
            // Remove markers
            const marker = sq.querySelector('.move-marker');
            if (marker) marker.remove();
            
            // Remove ghost pieces (hurdles) - identifiable by opacity 0.5
            const ghost = sq.querySelector('.piece-black');
            if (ghost && ghost.style.opacity === '0.5') ghost.remove();
            
            sq.classList.remove('target-square');
        });

        // 2. Render new targets
        if (frame.targets) {
            frame.targets.forEach(t => {
                const sq = this.getSquare(board, t.r, t.f);
                if (!sq) return;
                
                sq.classList.add('target-square');
                
                const marker = document.createElement('div');
                marker.className = `move-marker ${t.isSlide ? 'slide' : ''}`;
                marker.style.cssText = t.style;
                sq.appendChild(marker);
            });
        }

        // 3. Render new hurdles
        if (frame.hurdles) {
            frame.hurdles.forEach(h => {
                const sq = this.getSquare(board, h.r, h.f);
                if (!sq) return;
                
                // Only add if not occupied by main piece
                if (!sq.querySelector('.piece-white')) {
                    const ghost = document.createElement('span');
                    ghost.className = 'chess-piece piece-text piece-black';
                    ghost.style.opacity = '0.5';
                    ghost.textContent = 'p'; // Ghost pawn
                    sq.appendChild(ghost);
                }
            });
        }
    }

    getSquare(board, r, f) {
        // Find square by index (8*8 grid, rank 7 down to 0)
        // DOM order: Rank 7 (files 0-7), Rank 6...
        // Index = (7-r)*8 + f
        const index = (7 - r) * 8 + f;
        return board.querySelectorAll('.square')[index];
    }
}

// Initialize on load
document.addEventListener('DOMContentLoaded', () => {
    new ChessMoveAnimator();
});

