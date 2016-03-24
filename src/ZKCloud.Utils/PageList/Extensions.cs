﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2015-10-12
// Last Modified:			2015-10-25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKCloud.Utils.PageList
{
    public static class Extensions
    {
        //public static IPagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageIndex, int pageSize, int? totalCount = null)
        //{
        //    return new PagedList<T>(source, pageIndex, pageSize, totalCount);
        //}

        //public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageIndex, int pageSize, int? totalCount = null)
        //{
        //    return new PagedList<T>(source, pageIndex, pageSize, totalCount);
        //}


        public static List<string> ToStringList(this char[] chars)
        {
            List<string> list = new List<string>();
            foreach (char c in chars)
            {
                list.Add(c.ToString());
            }

            return list;
        }

        public static string ToCsv(this string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            string comma = string.Empty;
            foreach(string s in arr)
            {
                sb.Append(comma);
                sb.Append(s);
                comma = ",";
            }

            return sb.ToString();
            //return arr.
        }
    }
}
