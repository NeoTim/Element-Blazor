﻿
using Element.ClientRender.PWA.Demo.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.ClientRender.PWA.Demo.Upload
{
    public class UploadActivity
    {
        public string Name { get; set; }
        public Area Area { get; set; }
        public IFileModel[] Files { get; set; }
        public IFileModel[] Previews { get; set; }
        public override string ToString()
        {
            return $"名称：{Name},区域：{Area},审批文件：{string.Join(",", Files.Select(x => x.FileName))},场景预览：{string.Join(",", Previews.Select(x => x.FileName))}";
        }
    }
}
