﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Health.Platform.Entities.V3.ActionPlans
{
    using System;
    using System.Collections.ObjectModel;
    using Microsoft.Health.Platform.Entities.V3.Enums;

    /// <summary>
    /// An instance of an action plan associated to a user
    /// </summary>
    public class ActionPlanInstance : ActionPlan
    {
        /// <summary>
        /// The ID of the plan
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The status of the plan
        /// </summary>
        public ActionPlanStatus Status { get; set; }

        /// <summary>
        /// The Task instances associated with this plan
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Set needed for serialization.")]
        public Collection<ActionPlanTaskInstance> AssociatedTasks { get; set; }
    }
}