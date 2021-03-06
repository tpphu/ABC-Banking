﻿using System.Net;
using CashierSystem.Models;

namespace CashierSystem.WebService
{
    internal class DepositService : WebServiceBase
    {
        public bool ProcessDepositRequest(DepositRequest request)
        {
            //Webservice address
            string badStaticString = "http://localhost:50025/api/Deposit/ProcessDepositCashier";

            //1. Validate values
            //Do some checks here...

            //2. Make HTTP Request to web service
            HttpCustomResult response = MakeHttpRequest(badStaticString, request);

            //3. Handle response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //Success
                return true;
            }
            else
            {
                //Something went wrong. We don't care what at this time.
                return false;
            }
        }
    }
}