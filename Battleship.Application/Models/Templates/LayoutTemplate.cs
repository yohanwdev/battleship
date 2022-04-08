namespace Battleship.Application.Models.Templates
{
    public class LayoutTemplate
    {
        public string FirstShipLocation { get; set; }
        public string FirstDistroyerLocation { get; set; }
        public string SecondDistroyerLocation { get; set; }
    }

    public static class SampleTemplates
    {
        static List<LayoutTemplate> templates = new List<LayoutTemplate>()
        { 
            new LayoutTemplate() { FirstDistroyerLocation="A1", FirstShipLocation="B3", SecondDistroyerLocation="E4"},
            new LayoutTemplate() { FirstDistroyerLocation="B1", FirstShipLocation="C3", SecondDistroyerLocation="F4"},
            new LayoutTemplate() { FirstDistroyerLocation="C1", FirstShipLocation="D3", SecondDistroyerLocation="G4"},
            new LayoutTemplate() { FirstDistroyerLocation="D1", FirstShipLocation="E3", SecondDistroyerLocation="H4"},
            new LayoutTemplate() { FirstDistroyerLocation="E1", FirstShipLocation="F3", SecondDistroyerLocation="I4"},
        };

        public static List<LayoutTemplate> Templates { get => templates; set => templates = value; }
    }
}
