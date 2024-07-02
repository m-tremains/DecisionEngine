using BookKeeping.Services.Enums;
using System.Collections.Generic;
using System.Linq;

namespace BookKeeping.Services.Models
{
    public class ComponentModel
    {
        public ComponentModel(ComponentTypeEnum componentTypeEnum)
        {
            _componentType = componentTypeEnum;
        }

        public ComponentModel()
        {
        }

        private ComponentTypeEnum _componentType;
        public ComponentTypeEnum ComponentType => GetComponentType();
        public IReadOnlyCollection<ComponentModel> SubComponents { get; set; }

        private ComponentTypeEnum GetComponentType()
        {
            if (SubComponents == null
                || SubComponents.Any() == false)
            {
                return _componentType;
            }

            var isComposite = SubComponents.Any(a => a.ComponentType == ComponentTypeEnum.Composite)
                || SubComponents.Select(s => (int)s.ComponentType).Distinct().Count() > 1;
            if (isComposite)
            {
                return ComponentTypeEnum.Composite;
            }
            else
            {
                return SubComponents.FirstOrDefault().ComponentType;
            }
        }
    }
}
