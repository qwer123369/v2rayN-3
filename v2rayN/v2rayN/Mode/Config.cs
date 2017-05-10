﻿using System.Collections.Generic;

namespace v2rayN.Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    public class Config
    {

        /// <summary>
        /// 本地监听端口
        /// </summary>
        public int localPort { get; set; }

        /// <summary>
        /// 默认配置序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 允许日志
        /// </summary>
        public bool logEnabled { get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        public string loglevel { get; set; }

        /// <summary>
        /// 允许udp
        /// </summary>
        public bool udpEnabled { get; set; }

        /// <summary>
        /// vmess服务器信息
        /// </summary>
        public List<VmessItem> vmess { get; set; }

        /// <summary>
        /// 是否需要重启服务V2ray
        /// </summary>
        public bool reloadV2ray { get; set; }

        public string address()
        {
            return vmess[index].address;
        }

        public int port()
        {
            return vmess[index].port;
        }

        public string id()
        {
            return vmess[index].id;
        }

        public int alterId()
        {
            return vmess[index].alterId;
        }

        public string security()
        {
            return vmess[index].security;
        }

        public string remarks()
        {
            return vmess[index].remarks;
        }

    }

    public class VmessItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int alterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string security { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remarks { get; set; }
    }


}