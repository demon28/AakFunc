using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Models.DataBase
{
    [Serializable]
    [Table("tb_Account")]
    public   class AccountModel
    {
            /// <summary>
            /// Uid
            /// </summary>
            [Key]
            [Required(ErrorMessage = "Uid不能为空")]
            [Column("Uid")]
            [DisplayName("Uid")]
            public long Uid { get; set; }

            /// <summary>
            /// username
            /// </summary>
            [Required(ErrorMessage = "username不能为空")]
            [Column("username")]
            [DisplayName("username")]
            public string username { get; set; }

            /// <summary>
            /// ueserpwd
            /// </summary>
            [Required(ErrorMessage = "ueserpwd不能为空")]
            [Column("ueserpwd")]
            [DisplayName("ueserpwd")]
            public string ueserpwd { get; set; }

            /// <summary>
            /// user62data
            /// </summary>
            [Column("user62data")]
            [DisplayName("user62data")]
            public string user62data { get; set; }

            /// <summary>
            /// DeviceId
            /// </summary>
            [Required(ErrorMessage = "DeviceId不能为空")]
            [Column("DeviceId")]
            [DisplayName("DeviceId")]
            public string DeviceId { get; set; }

            /// <summary>
            /// ProxyIp
            /// </summary>
            [Column("ProxyIp")]
            [DisplayName("ProxyIp")]
            public string ProxyIp { get; set; }

            /// <summary>
            /// ProxyName
            /// </summary>
            [Column("ProxyName")]
            [DisplayName("ProxyName")]
            public string ProxyName { get; set; }

            /// <summary>
            /// ProxPwd
            /// </summary>
            [Column("ProxPwd")]
            [DisplayName("ProxPwd")]
            public string ProxPwd { get; set; }

            /// <summary>
            /// HeartBeat
            /// </summary>
            [Column("HeartBeat")]
            [DisplayName("HeartBeat")]
            public long? HeartBeat { get; set; }

            /// <summary>
            /// Status
            /// </summary>
            [Column("Status")]
            [DisplayName("Status")]
            public long? Status { get; set; }

            /// <summary>
            /// WxId
            /// </summary>
            [Column("WxId")]
            [DisplayName("WxId")]
            public string WxId { get; set; }

            /// <summary>
            /// Remarks
            /// </summary>
            [Column("Remarks")]
            [DisplayName("Remarks")]
            public string Remarks { get; set; }

            public override string ToString()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }
        }
    }


