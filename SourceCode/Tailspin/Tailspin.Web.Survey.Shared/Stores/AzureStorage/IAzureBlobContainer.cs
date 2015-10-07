﻿//===============================================================================
// Microsoft patterns & practices
// Windows Azure Architecture Guide
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://wag.codeplex.com/license)
//===============================================================================


namespace Tailspin.Web.Survey.Shared.Stores.AzureStorage
{
    using System;
    using System.Collections.Generic;
    using Microsoft.WindowsAzure.StorageClient;
    using Tailspin.Web.Survey.Shared.Stores.Azure;

    public interface IAzureBlobContainer<T> : IAzureObjectWithRetryPolicyFactory
    {
        void EnsureExist();

        bool AcquireLock(PessimisticConcurrencyContext context);
        void ReleaseLock(PessimisticConcurrencyContext context);

        T Get(string objId);
        T Get(string objId, out OptimisticConcurrencyContext context);
        IEnumerable<IListBlobItemWithName> GetBlobList();
        Uri GetUri(string objId);

        void Delete(string objId);
        void DeleteContainer();

        void Save(string objId, T obj);
        void Save(IConcurrencyControlContext context, T obj);
    }
}