namespace Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects
{
    public interface IImageFileInfoDTO
    {
        byte[] Image { get; set; }
        string Name { get; set; }
        string Name2 { get; }
        string Src { get; set; }
        string Type { get; set; }
        bool IsLoading { get; set; }
    }
}