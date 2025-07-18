namespace CoffeeMachine.Api.Models
{
    public class CreateCoffeeMachineRequest
    {
        public string Name { get; set; } = string.Empty;
        public bool HasBrewingModule { get; set; }
        public bool HasGrindingModule { get; set; }
        public bool HasWifiModule { get; set; }
    }
}
