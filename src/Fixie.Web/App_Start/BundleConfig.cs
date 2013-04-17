using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;

namespace Fixie.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssTransformer = new CssTransformer();
            var jsTransformer = new JsTransformer();
            var nullOrderer = new NullOrderer();

            var commonStylesBundle = new Bundle("~/Bundles/CommonStyles");
            commonStylesBundle.Include(
               "~/Content/less/bootstrap.less",
               "~/Content/less/responsive.less");
            commonStylesBundle.Transforms.Add(cssTransformer);
            commonStylesBundle.Orderer = nullOrderer;

            bundles.Add(commonStylesBundle);

            var commonScriptsBundle = new Bundle("~/Bundles/CommonScripts");
            commonScriptsBundle.Include(
               "~/Scripts/jquery-{version}.js",
               "~/Scripts/less.min.js",
               "~/Scripts/bootstrap.js",
               "~/Scripts/angular.js",
               "~/Scripts/linq.js");
            commonScriptsBundle.Transforms.Add(jsTransformer);
            commonScriptsBundle.Orderer = nullOrderer;

            bundles.Add(commonScriptsBundle);
        }
    }
}