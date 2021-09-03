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

            string message = _c.TransactionMessages.Where(c => c.TransactionMessageSlug == slug).FirstOrDefault().TransactionMessageContent;

            TransactionLog transactionLog = new TransactionLog();

            
            
            transactionLog.ProjectID = projectID;
            transactionLog.TransactionLogSlug = slug;
            transactionLog.TransactionLogRead = false;
            transactionLog.TransactionLogMessageContent = message;
            

            return transactionLog;
        }
    }
}
