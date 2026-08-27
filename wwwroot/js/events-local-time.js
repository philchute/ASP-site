/**
 * Events page helpers: persist timezone, send browser IANA for "local",
 * and open the calendar day panel.
 */
(function () {
    var STORAGE_KEY = 'eventsTz';
    var APPLIED_KEY = 'eventsTzApplied';

    function getBrowserIana() {
        try {
            return Intl.DateTimeFormat().resolvedOptions().timeZone || '';
        } catch (e) {
            return '';
        }
    }

    function openDay(iso) {
        var panel = document.getElementById('event-day-panel');
        if (!panel) return;
        panel.hidden = false;
        var title = document.getElementById('event-day-panel-title');
        var empty = document.getElementById('event-day-panel-empty');
        var bodies = panel.querySelectorAll('.event-day-panel-body');
        var match = null;
        bodies.forEach(function (body) {
            var isMatch = body.getAttribute('data-day') === iso;
            body.hidden = !isMatch;
            if (isMatch) match = body;
        });
        if (empty) empty.hidden = !!match;
        if (title) {
            var date = iso ? new Date(iso + 'T12:00:00') : null;
            var label = date && !isNaN(date.getTime())
                ? date.toLocaleDateString(undefined, { weekday: 'long', month: 'long', day: 'numeric', year: 'numeric' })
                : iso;
            title.textContent = match ? label : (label ? label : 'Events');
            if (!match && empty) {
                empty.textContent = 'No events on this day.';
            }
        }
        panel.scrollIntoView({ behavior: 'smooth', block: 'nearest' });
        if (iso) {
            history.replaceState(null, '', '#' + iso);
        }
    }

    function closePanel() {
        var panel = document.getElementById('event-day-panel');
        if (!panel) return;
        panel.hidden = true;
        if (location.hash) {
            history.replaceState(null, '', location.pathname + location.search);
        }
    }

    function initCalendarPanel() {
        var grid = document.querySelector('.event-cal-grid');
        if (!grid) return;
        grid.addEventListener('click', function (ev) {
            var target = ev.target.closest('[data-day]');
            if (!target || !grid.contains(target)) return;
            var iso = target.getAttribute('data-day');
            if (iso) openDay(iso);
        });
        var closeBtn = document.getElementById('event-day-panel-close');
        if (closeBtn) closeBtn.addEventListener('click', closePanel);

        var hash = (location.hash || '').replace('#', '');
        if (/^\d{4}-\d{2}-\d{2}$/.test(hash)) {
            openDay(hash);
        }
    }

    function initTimezone() {
        var form = document.getElementById('events-filter-form');
        var tzSelect = document.getElementById('Tz');
        var tzIanaInput = document.getElementById('TzIana');
        var iana = getBrowserIana();
        if (tzIanaInput && iana) {
            tzIanaInput.value = iana;
        }

        var params = new URLSearchParams(window.location.search);
        if (!params.has('Tz')) {
            var saved = null;
            try { saved = localStorage.getItem(STORAGE_KEY); } catch (e) { /* ignore */ }
            if (saved && saved !== 'ET' && form && tzSelect) {
                var already = false;
                try { already = sessionStorage.getItem(APPLIED_KEY) === '1'; } catch (e) { /* ignore */ }
                if (!already) {
                    try { sessionStorage.setItem(APPLIED_KEY, '1'); } catch (e) { /* ignore */ }
                    tzSelect.value = saved;
                    form.submit();
                    return true;
                }
            }
        } else {
            try { sessionStorage.removeItem(APPLIED_KEY); } catch (e) { /* ignore */ }
        }

        if (tzSelect) {
            try { localStorage.setItem(STORAGE_KEY, tzSelect.value); } catch (e) { /* ignore */ }
            tzSelect.addEventListener('change', function () {
                try { localStorage.setItem(STORAGE_KEY, tzSelect.value); } catch (e) { /* ignore */ }
                if (tzIanaInput && iana) tzIanaInput.value = iana;
            });
        }
        return false;
    }

    function init() {
        var reloading = initTimezone();
        if (reloading) return;
        initCalendarPanel();
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', init);
    } else {
        init();
    }
})();
