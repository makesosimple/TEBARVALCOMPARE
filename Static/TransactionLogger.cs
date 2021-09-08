using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;

namespace IBBPortal.Static
{
    public static class TransactionLogger
    {
        public static TransactionLog logTransaction(ApplicationDbContext _c, int projectID, string slug, string UserID)
        {

            //ApplicationDbContext _transactionContext = new ApplicationDbContext();
            string message;
            try
            {
                 message = _c.TransactionMessages.Where(c => c.TransactionMessageSlug == slug).First().TransactionMessageContent;
            } catch
            {
                 message = slug + " temalı mesaj denemesi oluştu";
            }
            

            TransactionLog transactionLog = new TransactionLog();

            transactionLog.ProjectID = projectID;
            transactionLog.TransactionLogSlug = slug;
            transactionLog.TransactionLogRead = false;
            transactionLog.TransactionLogForUserID = UserID;
            if (message != null)
            {
                transactionLog.TransactionLogMessageContent = message;
            }

            transactionLog.CreationDate = DateTime.Now;
            _c.Add(transactionLog);
            _c.SaveChanges();

            return transactionLog;
        }
    }
}
