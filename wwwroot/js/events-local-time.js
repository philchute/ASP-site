/**
 * Converts event times from ET (stored as UTC in data-et) to the user's local timezone.
 * Elements with data-et get their content replaced with local time on load.
 * Updates timezone indicator: "ET" if user is in Eastern, "local" otherwise.
 */
(function () {
    function formatLocalTime(isoUtcString, showFullDate) {
        try {
            var date = new Date(isoUtcString);
            if (isNaN(date.getTime())) return null;
            if (showFullDate) {
                return date.toLocaleString(undefined, {
                    month: 'short',
                    day: 'numeric',
                    year: 'numeric',
                    hour: 'numeric',
                    minute: '2-digit',
                    hour12: true
                });
            }
            return date.toLocaleTimeString(undefined, {
                hour: 'numeric',
                minute: '2-digit',
                hour12: true
            });
        } catch (e) {
            return null;
        }
    }

    function updateTimezoneIndicator() {
        try {
            var tz = Intl.DateTimeFormat().resolvedOptions().timeZone;
            var isET = tz === 'America/New_York';
            document.querySelectorAll('.tz-label').forEach(function (el) {
                el.textContent = isET ? 'ET' : 'local';
            });
            document.querySelectorAll('.tz-label-col').forEach(function (el) {
                el.textContent = isET ? '(ET)' : '(local)';
            });
        } catch (e) { /* ignore */ }
    }

    function init() {
        var elements = document.querySelectorAll('.event-time-local[data-et]');
        elements.forEach(function (el) {
            var iso = el.getAttribute('data-et');
            if (!iso) return;
            var showFull = el.getAttribute('data-et-format') === 'full';
            var localStr = formatLocalTime(iso, showFull);
            if (localStr) {
                el.textContent = localStr;
            }
        });
        updateTimezoneIndicator();
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', init);
    } else {
        init();
    }
})();
