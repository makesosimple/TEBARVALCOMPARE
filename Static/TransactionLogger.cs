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
            int messageID;
            int messageType;
            try
            {
                message = _c.TransactionMessages.Where(c => c.TransactionMessageSlug == slug).First().TransactionMessageContent;
                messageID = _c.TransactionMessages.Where(c => c.TransactionMessageSlug == slug).First().TransactionMessageID;
                messageType = (int)_c.TransactionMessages.Where(c => c.TransactionMessageSlug == slug).First().TransactionTypeID;
            } catch
            {
                message = _c.TransactionMessages.First().TransactionMessageContent + slug;
                messageID = _c.TransactionMessages.First().TransactionMessageID;
                messageType = (int)_c.TransactionMessages.First().TransactionTypeID;
                slug = "unknown-transaction";
            }
            

            TransactionLog transactionLog = new TransactionLog();

            transactionLog.ProjectID = projectID;
            transactionLog.TransactionLogSlug = slug;
            transactionLog.TransactionLogRead = false;
            transactionLog.TransactionLogForUserID = UserID;
            transactionLog.TransactionMessageID = messageID;
            transactionLog.TransactionTypeID = messageType;
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
