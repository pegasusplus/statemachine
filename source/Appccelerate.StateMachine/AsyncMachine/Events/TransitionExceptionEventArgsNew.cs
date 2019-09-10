//-------------------------------------------------------------------------------
// <copyright file="TransitionExceptionEventArgsNew.cs" company="Appccelerate">
//   Copyright (c) 2008-2019 Appccelerate
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.StateMachine.AsyncMachine.Events
{
    using System;

    /// <summary>
    /// Event arguments providing transition exceptions.
    /// </summary>
    /// <typeparam name="TState">The type of the state.</typeparam>
    /// <typeparam name="TEvent">The type of the event.</typeparam>
    public class TransitionExceptionEventArgsNew<TState, TEvent>
        : TransitionEventArgsNew<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionExceptionEventArgsNew&lt;TState, TEvent&gt;"/> class.
        /// </summary>
        /// <param name="context">The event context.</param>
        /// <param name="exception">The exception.</param>
        public TransitionExceptionEventArgsNew(ITransitionContextNew<TState, TEvent> context, Exception exception)
            : base(context)
        {
            this.Exception = exception;
        }

        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        public Exception Exception { get; }
    }
}