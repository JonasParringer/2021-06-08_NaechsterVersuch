using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_08_NaechsterVersuch.Models;
using Microsoft.Extensions.Logging;

public class DocumentContext : DbContext
    {
        ILoggerFactory loggerFactory;

    //loggerFactory = new LoggerFactory().AddConsole()
    // loggerFactory = new LoggerFactory().AddConsole((categoryName, logLevel) => (logLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name));
    LoggerFactory = new LoggerFactory().AddConsole((categoryName, LogLevel) => (LogLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name));



        public DocumentContext (DbContextOptions<DocumentContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_08_NaechsterVersuch.Models.Document> Document { get; set; }
    }
