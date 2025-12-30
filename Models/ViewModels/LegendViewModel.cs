namespace ASP_site.Models.ViewModels
{
    public class LegendViewModel
    {
        public bool ShowMoveOnly { get; set; } = false;
        public bool ShowCaptureOnly { get; set; } = false;
        public bool ShowMoveAndCapture { get; set; } = false;
        public bool ShowHopper { get; set; } = false;
        public bool ShowLame { get; set; } = false;
        public bool ShowImmune { get; set; } = false;
        public bool ShowPromotion { get; set; } = false;
        public bool ShowExplode { get; set; } = false;
        public bool ShowPowerTransfer { get; set; } = false;
        public bool ShowEnPassant { get; set; } = false;

        // Default: Show all basic ones if nothing specified? 
        // Or if empty, show all (for backward compatibility or default view)
        // But user asked to clutter less.
        // Let's make a method to "ShowAll" for default pages.
        
        public static LegendViewModel All()
        {
            return new LegendViewModel
            {
                ShowMoveOnly = true, ShowCaptureOnly = true, ShowMoveAndCapture = true,
                ShowHopper = true, ShowLame = true, ShowImmune = true, ShowPromotion = true,
                ShowExplode = true, ShowPowerTransfer = true, ShowEnPassant = true
            };
        }

        public static LegendViewModel FromMoves(IEnumerable<ASP_site.Helpers.MoveTrajectory> moves)
        {
            var vm = new LegendViewModel();
            if (moves == null) return vm;

            foreach (var m in moves)
            {
                if (m.IsMove && !m.IsCapture) vm.ShowMoveOnly = true;
                if (!m.IsMove && m.IsCapture) vm.ShowCaptureOnly = true;
                if (m.IsMove && m.IsCapture) vm.ShowMoveAndCapture = true;

                // IsGrasshopper property removed from Trajectory (baked into IsHopper behavior)
                // Assuming IsHopper covers both for now.
                if (m.IsHopper) vm.ShowHopper = true;
                if (m.IsLame) vm.ShowLame = true;
                
                // Check attributes for "Immune" or "Promotion"?
                if (m.Attributes.Contains("Immune")) vm.ShowImmune = true;
                if (m.Attributes.Contains("Promotion")) vm.ShowPromotion = true;

                if (m.IsExplode) vm.ShowExplode = true;
                if (m.IsPowerTransfer) vm.ShowPowerTransfer = true;
                if (m.IsEnPassant) vm.ShowEnPassant = true;
            }
            return vm;
        }
    }
}

