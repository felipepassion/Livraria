﻿using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.SystemSettings.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
    public partial class UserProfileAccessListiningDTO : SteppableEntityDTO
	{
            }
    public partial class UserCurrentAccessSelectedListiningDTO : EntityDTO
	{
            }
    public partial class UserProfileListListiningDTO : EntityDTO
	{
            }
    public partial class UserProfileListiningDTO : EntityDTO
	{
            }
    public partial class UserListiningDTO : EntityDTO
	{
            }
}
namespace Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests 
{
	using Requests;
 [H2("Submenu")]     public partial class SystemPanelSubItemListiningDTO : ActivableEntityDTO
	{
         [DisplayOnList,Title] public  string Description { get; set; }[DisplayOnList,Subtitle] public  string? Url { get; set; }     }
 [H2("Sidebar")]     public partial class SystemPanelListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList(0)] public  string? Icon { get; set; }[DisplayOnList,DisplayName("Menu"),Title] public  string Description { get; set; }[DisplayOnList,DisplayName("Code"),Subtitle] public  string Code { get; set; }     }
 [H2("Grupo de Menus / Painéis")]     public partial class SystemPanelGroupListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList,DisplayName("Description"),Title] public  string Description { get; set; }[DisplayOnList,DisplayName("Code"),Subtitle] public  string Code { get; set; }[DisplayOnList] public  bool? IsPrivate { get; set; }[DisplayOnList,DisplayName("Menus")] public List<Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelListiningDTO>? SubItems { get; set; } = new List<Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelListiningDTO>();     }
    public partial class CargaTabelaListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList(0),DisplayName("Name da Tabela"),Title] public  string? TableName { get; set; }[DisplayOnList(1),DisplayName("Caminho do arquivo .csv")] public  string? FilePath { get; set; }     }
    public partial class SystemSettingsAggSettingsListiningDTO : EntityDTO
	{
              }
}
