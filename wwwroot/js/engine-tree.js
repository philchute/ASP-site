document.addEventListener("DOMContentLoaded", function () {
    var selected = document.querySelector(".engine-node.is-selected");
    if (selected) {
        selected.scrollIntoView({ block: "center", behavior: "smooth" });
    }

    if (typeof bootstrap === "undefined" || !bootstrap.Popover) {
        return;
    }

    document.querySelectorAll('[data-bs-toggle="popover"][data-bs-content]').forEach(function (el) {
        new bootstrap.Popover(el, {
            container: "body",
            html: true,
            trigger: "hover focus",
            placement: "auto",
            customClass: "engine-game-popover"
        });
    });
});
