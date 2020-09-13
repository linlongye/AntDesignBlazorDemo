using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AntDesignModels
{
    public class ModelBase
    {
        [DisplayName("主键Id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("创建时间")] public DateTime? CreateTime { get; set; }
        [DisplayName("最后更新时间")] public DateTime? LastUpdate { get; set; }
        [DisplayName("最后更新时间")] public string LastUpdater { get; set; }
        [DisplayName("创建人")] public string Creator { get; set; }
    }
}