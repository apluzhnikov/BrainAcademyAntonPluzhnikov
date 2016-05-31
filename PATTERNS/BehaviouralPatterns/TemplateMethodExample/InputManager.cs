using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.TemplateMethodExample
{
    abstract class InputManager<T> where T : class
    {
        protected abstract bool AskQuestion();
        protected abstract string ReadAnswer();
        protected abstract bool IsValid(string responce);
        protected abstract T CreateEntity(string responce);

        /// <summary>
        /// it's a template method
        /// </summary>
        /// <returns></returns>
        public T Create() {
            if (!AskQuestion())
                throw new OperationCanceledException("Input process has been canceled");
            var responce = ReadAnswer();

            if(!IsValid(responce))
                throw new InvalidOperationException("Input value is incorrect");

            return CreateEntity(responce);
        }
    }
}
