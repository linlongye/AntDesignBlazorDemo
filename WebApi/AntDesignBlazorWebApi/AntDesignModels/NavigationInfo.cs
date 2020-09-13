using System.Collections.Generic;
using System.ComponentModel;

namespace AntDesignModels
{
    /**
     * 菜单信息
     */
    public class NavigationInfo : ModelBase
    {
        [DisplayName("菜单名称")] public string Text { get; set; }
        [DisplayName("菜单路径")] public string Path { get; set; }
        [DisplayName("菜单类型")] public NavigationType NavigationType { get; set; }
        [DisplayName("父级Id")] public int ParentId { get; set; }
        public virtual NavigationInfo Parent { get; set; }
        public virtual ICollection<NavigationInfo> Children { get; set; }
    }
}