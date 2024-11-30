
using CsvHelper.Configuration;
namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Profiles
{
	using Application.DTO.Aggregates.SystemSettingsAgg.Requests;
	using Entities;
	public partial class SystemPanelSubItemCsvMap : ClassMap<SystemPanelSubItem>
	{
		public SystemPanelSubItemCsvMap()
		{
			Map(x=>x.SubItems).Name("SubItems");Map(x=>x.SystemPanelSubItemId).Name("SystemPanelSubItemId");Map(x=>x.SystemPanelId).Name("SystemPanelId");Map(x=>x.IsSubItem).Name("IsSubItem");Map(x=>x.Position).Name("Position");
		}
	}
	public partial class SystemPanelCsvMap : ClassMap<SystemPanel>
	{
		public SystemPanelCsvMap()
		{
			Map(x=>x.Icon).Name("Icon");Map(x=>x.Description).Name("Description");Map(x=>x.Code).Name("Code");Map(x=>x.GroupOfMenus).Name("GroupOfMenus");Map(x=>x.SubItems).Name("SubItems");Map(x=>x.AccessesOfMyProfile).Name("AccessesOfMyProfile");
		}
	}
	public partial class SystemPanelGroupCsvMap : ClassMap<SystemPanelGroup>
	{
		public SystemPanelGroupCsvMap()
		{
			Map(x=>x.Icon).Name("Icon");Map(x=>x.Description).Name("Description");Map(x=>x.Code).Name("Code");Map(x=>x.IsPrivate).Name("IsPrivate");Map(x=>x.SubItems).Name("SubItems");Map(x=>x.AccessesOfMyProfile).Name("AccessesOfMyProfile");
		}
	}
	public partial class CargaTabelaCsvMap : ClassMap<CargaTabela>
	{
		public CargaTabelaCsvMap()
		{
			Map(x=>x.TableName).Name("TableName");Map(x=>x.FilePath).Name("FilePath");Map(x=>x.IsInitialized).Name("IsInitialized");Map(x=>x.ArquivoCSV).Name("ArquivoCSV");Map(x=>x.Total).Name("Total");
		}
	}
	public partial class SystemSettingsAggSettingsCsvMap : ClassMap<SystemSettingsAggSettings>
	{
		public SystemSettingsAggSettingsCsvMap()
		{
			
		}
	}
}
