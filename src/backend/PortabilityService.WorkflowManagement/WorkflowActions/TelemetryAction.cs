﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading;
using System.Threading.Tasks;

namespace PortabilityService.WorkflowManagement
{
    internal class TelemetryAction : BaseAction, IWorkflowAction
    {
        public TelemetryAction(string serviceUrl) : base(serviceUrl) { }

        public async Task<WorkflowStage> ExecuteAsync(string submissionId, CancellationToken cancelToken)
        {
            // TODO: Update to call Telemetry Collection Service
            await Task.Delay(5);

            return WorkflowStage.Finished;
        }

        public WorkflowStage CurrentStage
        {
            get { return WorkflowStage.Telemetry; }
        }
    }
}