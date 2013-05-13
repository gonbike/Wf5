﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sys.Workflow.DataModel;

namespace Sys.Workflow.Business
{
    /// <summary>
    /// 流程实体类
    /// </summary>
    [DataStorage("WfProcess")]
    public class ProcessEntity
    {
        public System.Guid ProcessGUID { get; set; }
        public string ProcessName { get; set; }
        public string PageUrl { get; set; }
        public string XmlFileName { get; set; }
        public string XmlFilePath { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
    }
}
