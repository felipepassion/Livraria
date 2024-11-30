using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities
{
    public abstract class SteppableEntity : ActivableEntity
    {
        public void ChangeStep(int newStep)
        {
            this.CurrentStep = newStep;
            if (!this.Active.HasValue && this.CurrentStep >= this.MaxSteps)
                this.Active = true;
        }
        public int CurrentStep { get; set; }
        public int? MaxSteps => this.GetType().GetCustomAttribute<Steppable>()?.Quantity;
        public bool? RegisterDone { get; set; }
    }

    public abstract class ActivableEntity : Entity
    {
        [DisplayName("Habilitado?")]
        public bool? Active { get; set; } = true;

        public void Enable()
        {
            this.Active = true;
        }

        public void Disable()
        {
            this.Active = false;
        }
    }

    public interface IEntity
    {
        public int Id { get; set; }
        public string IdExterno { get; set; }
        string GetTitle();
        string GetTitlePropName();
        DateTime? CriadoEm { get; set; }
    }

    public class Entity : IEntity
    {
        [NotMapped]
        [IgnorePropertyT4]
        private List<BaseEvent> _domainEvents;

        public Entity()
        {
            CriadoEm ??= DateTime.UtcNow;
            _idExterno ??= Guid.NewGuid().ToString();
        }

        string _idExterno;
        public string IdExterno
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_idExterno))
                {
                    CriadoEm ??= DateTime.UtcNow;
                    _idExterno = Guid.NewGuid().ToString();
                }
                return _idExterno;
            }
            set { this._idExterno = value; }
        }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Criado em")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [IgnorePropertyT4OnRequest]
        [DisplayName("Atualizado em")]
        public DateTime? AtualizadoEm { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Deletado em")]
        public DateTime? DeletadoEm { get; set; }

        protected virtual void Updated()
        {
            this.AtualizadoEm = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string GetTitle()
        {
            var val = this.GetValueWithAttribute<Title>()?.ToString();
            if (string.IsNullOrWhiteSpace(val))
            {
                val = this.GetType().GetCustomAttribute<H1>()?.Title ?? null;
            }
            return val;
        }

        public string GetTitlePropName()
        {
            var property = this.GetFieldInfoByWithAttribute<Title>();
            var test = property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "Título";
            return property?.Name;
        }


        [IgnorePropertyT4OnRequest]
        public bool Deletado { get; set; }

        [NotMapped]
        [IgnorePropertyT4]
        public List<BaseEvent> DomainEvents { get { return _domainEvents; } set { _domainEvents = _domainEvents ?? value; } }

        //[Column(TypeName = "jsonb"), NotMapped]
        //public List<EventsHistory>? EventsHistory { get; set; }
        public void Delete()
        {
            this.Deletado = true;
            this.DeletadoEm = DateTime.UtcNow;
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public void AddDomainEvent(BaseEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<BaseEvent>();
            //_domainEvents.Add(domainEvent);
        }

        public bool IsEmpty()
        {
            return this.IsEmpty();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not IEntity) return false;

            return ((Entity)obj)?.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
