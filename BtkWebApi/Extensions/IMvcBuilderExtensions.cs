﻿using BtkWebApi.Utilites.Formatters;

namespace BtkWebApi.Extensions
{
    public static class IMvcBuilderExtensions
    {
        public static IMvcBuilder AddCustomCsvFormatter(this IMvcBuilder builder)
        {
            return builder.AddMvcOptions(config =>
            {
                config.OutputFormatters.Add(new CsvOutputFormatter());
            });
        }
    }
}
