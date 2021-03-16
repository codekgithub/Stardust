using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Stardust.Data
{
    /// <summary>应用消费。应用消费的服务</summary>
    [Serializable]
    [DataObject]
    [Description("应用消费。应用消费的服务")]
    [BindIndex("IX_AppConsume_AppId", false, "AppId")]
    [BindIndex("IX_AppConsume_ServiceName", false, "ServiceName")]
    [BindTable("AppConsume", Description = "应用消费。应用消费的服务", ConnName = "Stardust", DbType = DatabaseType.None)]
    public partial class AppConsume
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "")]
        public Int32 Id { get => _Id; set { if (OnPropertyChanging("Id", value)) { _Id = value; OnPropertyChanged("Id"); } } }

        private Int32 _AppId;
        /// <summary>应用</summary>
        [DisplayName("应用")]
        [Description("应用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AppId", "应用", "")]
        public Int32 AppId { get => _AppId; set { if (OnPropertyChanging("AppId", value)) { _AppId = value; OnPropertyChanged("AppId"); } } }

        private String _ServiceName;
        /// <summary>服务名</summary>
        [DisplayName("服务名")]
        [Description("服务名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ServiceName", "服务名", "")]
        public String ServiceName { get => _ServiceName; set { if (OnPropertyChanging("ServiceName", value)) { _ServiceName = value; OnPropertyChanged("ServiceName"); } } }

        private String _Client;
        /// <summary>客户端。IP加进程</summary>
        [DisplayName("客户端")]
        [Description("客户端。IP加进程")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Client", "客户端。IP加进程", "")]
        public String Client { get => _Client; set { if (OnPropertyChanging("Client", value)) { _Client = value; OnPropertyChanged("Client"); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get => _Enable; set { if (OnPropertyChanging("Enable", value)) { _Enable = value; OnPropertyChanged("Enable"); } } }

        private String _MinVersion;
        /// <summary>最低版本。要求返回大于等于该版本的服务提供者</summary>
        [DisplayName("最低版本")]
        [Description("最低版本。要求返回大于等于该版本的服务提供者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MinVersion", "最低版本。要求返回大于等于该版本的服务提供者", "")]
        public String MinVersion { get => _MinVersion; set { if (OnPropertyChanging("MinVersion", value)) { _MinVersion = value; OnPropertyChanged("MinVersion"); } } }

        private String _Tag;
        /// <summary>标签。带有指定特性，逗号分隔</summary>
        [DisplayName("标签")]
        [Description("标签。带有指定特性，逗号分隔")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Tag", "标签。带有指定特性，逗号分隔", "")]
        public String Tag { get => _Tag; set { if (OnPropertyChanging("Tag", value)) { _Tag = value; OnPropertyChanged("Tag"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "Id": return _Id;
                    case "AppId": return _AppId;
                    case "ServiceName": return _ServiceName;
                    case "Client": return _Client;
                    case "Enable": return _Enable;
                    case "MinVersion": return _MinVersion;
                    case "Tag": return _Tag;
                    case "CreateTime": return _CreateTime;
                    case "CreateIP": return _CreateIP;
                    case "UpdateTime": return _UpdateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Id": _Id = value.ToInt(); break;
                    case "AppId": _AppId = value.ToInt(); break;
                    case "ServiceName": _ServiceName = Convert.ToString(value); break;
                    case "Client": _Client = Convert.ToString(value); break;
                    case "Enable": _Enable = value.ToBoolean(); break;
                    case "MinVersion": _MinVersion = Convert.ToString(value); break;
                    case "Tag": _Tag = Convert.ToString(value); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得应用消费字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName("Id");

            /// <summary>应用</summary>
            public static readonly Field AppId = FindByName("AppId");

            /// <summary>服务名</summary>
            public static readonly Field ServiceName = FindByName("ServiceName");

            /// <summary>客户端。IP加进程</summary>
            public static readonly Field Client = FindByName("Client");

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName("Enable");

            /// <summary>最低版本。要求返回大于等于该版本的服务提供者</summary>
            public static readonly Field MinVersion = FindByName("MinVersion");

            /// <summary>标签。带有指定特性，逗号分隔</summary>
            public static readonly Field Tag = FindByName("Tag");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得应用消费字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>应用</summary>
            public const String AppId = "AppId";

            /// <summary>服务名</summary>
            public const String ServiceName = "ServiceName";

            /// <summary>客户端。IP加进程</summary>
            public const String Client = "Client";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>最低版本。要求返回大于等于该版本的服务提供者</summary>
            public const String MinVersion = "MinVersion";

            /// <summary>标签。带有指定特性，逗号分隔</summary>
            public const String Tag = "Tag";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";
        }
        #endregion
    }
}