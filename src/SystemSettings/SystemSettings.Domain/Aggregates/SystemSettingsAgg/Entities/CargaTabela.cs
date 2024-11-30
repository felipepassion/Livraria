using System.ComponentModel;
using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll), Steppable(1), DoNotReplaceAfterGenerated]
    public class CargaTabela : SteppableEntity
    {
        [Step(1), Title, DisplayOnList(0), DisplayName("Name da Tabela")]
        public string TableName { get; set; }
        
        [Step(1), DisplayOnList(1), DisplayName("Caminho do arquivo .csv")]
        public string? FilePath { get; set; }
        
        [Step(1), DisplayName("Inicializado?")]
        public bool IsInitialized { get; set; }

        [Step(1), RequiredT4]
        public byte[]? ArquivoCSV { get; set; }

        public int? Total { get; set; }
    }
}
