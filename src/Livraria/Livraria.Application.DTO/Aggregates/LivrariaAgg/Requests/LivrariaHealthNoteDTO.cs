namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

public partial class LivrariaHealthNoteDTO
{
    public int BathroomTrips => new Random().Next(0, 5);
    public int? Calories => (int)(this.Meals?.Sum(m => m.Calories));
    public int? WaterIntakeInL => (int)(this.Liquids?.Where(x=>x.QuantityType == Enumerations.QuantityType.L)?.Sum(l => l.Quantity));
    public int? WaterIntakeInML=> (int)(this.Liquids?.Where(x=>x.QuantityType == Enumerations.QuantityType.ML)?.Sum(l => l.Quantity));
    
    public double? TotalWaterInTakeInL => (WaterIntakeInL + ((double)this.WaterIntakeInML / 1000));

}
