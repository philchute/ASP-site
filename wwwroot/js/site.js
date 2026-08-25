// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.timeline-row').forEach(function (row) {
        function toggle() {
            var open = row.classList.toggle('is-open');
            row.setAttribute('aria-expanded', open ? 'true' : 'false');
        }

        row.addEventListener('click', function (event) {
            if (event.target.closest('a')) return;
            toggle();
        });

        row.addEventListener('keydown', function (event) {
            if (event.key === 'Enter' || event.key === ' ') {
                event.preventDefault();
                toggle();
            }
        });
    });
});
