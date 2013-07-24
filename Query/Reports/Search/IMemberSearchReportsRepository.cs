﻿using System;
using System.Collections.Generic;
using LinkMe.Domain;
using LinkMe.Domain.Channels;

namespace LinkMe.Query.Reports.Search
{
    public interface IMemberSearchReportsRepository
    {
        // Searches.

        int GetAllMemberSearches(DateTimeRange timeRange);
        int GetMemberSearches(Channel channel, DateTimeRange timeRange);
        int GetFilterMemberSearches(Channel channel, DateTimeRange timeRange);
        int GetSavedMemberSearches(Channel channel, DateTimeRange timeRange);
        int GetAnonymousMemberSearches(Channel channel, DateTimeRange timeRange);
        int GetMemberSearches(Guid searcherId, DateTimeRange timeRange);
        IDictionary<Guid, int> GetMemberSearches(IEnumerable<Guid> searcherIds, DateTimeRange timeRange);

        // Search alerts.

        int GetMemberSearchAlerts();
        int GetMemberSearchAlerts(Guid searcherId);
        IDictionary<Guid, int> GetMemberSearchAlerts(IEnumerable<Guid> searcherIds);
    }
}