﻿namespace Microsoft.Web.Mvc.AspNet4.Test {
    using System;
    using System.Reflection;
    using System.Web;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class ExceptionHelper {
        private static TException ExpectExceptionHelper<TException>(GenericDelegate del) where TException : Exception {
            return ExpectExceptionHelper<TException>(del, false);
        }

        private static TException ExpectExceptionHelper<TException>(GenericDelegate del, bool allowDerivedExceptions)
            where TException : Exception {
            try {
                del();
                Assert.Fail("Expected exception of type " + typeof(TException) + ".");
                throw new Exception("can't happen");
            }
            catch (TException e) {
                if (!allowDerivedExceptions) {
                    Assert.AreEqual(typeof(TException), e.GetType());
                }
                return e;
            }
            catch (TargetInvocationException e) {
                TException te = e.InnerException as TException;
                if (te == null) {
                    // Rethrow if it's not the right type
                    throw;
                }
                if (!allowDerivedExceptions) {
                    Assert.AreEqual(typeof(TException), te.GetType());
                }
                return te;
            }
        }

        public static TException ExpectException<TException>(GenericDelegate del) where TException : Exception {
            return ExpectException<TException>(del, false);
        }

        public static TException ExpectException<TException>(GenericDelegate del, bool allowDerivedExceptions)
            where TException : Exception {
            if (typeof(ArgumentNullException).IsAssignableFrom(typeof(TException))) {
                throw new InvalidOperationException(
                    "ExpectException<TException>() cannot be used with exceptions of type 'ArgumentNullException'. " +
                    "Use ExpectArgumentNullException() instead.");
            }
            else if (typeof(ArgumentException).IsAssignableFrom(typeof(TException))) {
                throw new InvalidOperationException(
                    "ExpectException<TException>() cannot be used with exceptions of type 'ArgumentException'. " +
                    "Use ExpectArgumentException() instead.");
            }
            return ExpectExceptionHelper<TException>(del, allowDerivedExceptions);
        }

        public static TException ExpectException<TException>(GenericDelegate del, string exceptionMessage)
                                                       where TException : Exception {
            TException e = ExpectException<TException>(del);
            // Only check exception message on English build and OS, since some exception messages come from the OS
            // and will be in the native language.
            Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            return e;
        }

        public static ArgumentException ExpectArgumentException(GenericDelegate del, string exceptionMessage) {
            ArgumentException e = ExpectExceptionHelper<ArgumentException>(del);
            // Only check exception message on English build and OS, since some exception messages come from the OS
            // and will be in the native language.
            Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            return e;
        }

        public static ArgumentException ExpectArgumentExceptionNullOrEmpty(GenericDelegate del, string paramName) {
            return ExpectArgumentException(del, "Value cannot be null or empty.\r\nParameter name: " + paramName);
        }

        public static ArgumentNullException ExpectArgumentNullException(GenericDelegate del, string paramName) {
            ArgumentNullException e = ExpectExceptionHelper<ArgumentNullException>(del);
            Assert.AreEqual(paramName, e.ParamName, "Incorrect exception parameter name.");
            return e;
        }

        public static ArgumentNullException ExpectArgumentNullException<T>(Func<T> del, string paramName) {
            ArgumentNullException e = ExpectExceptionHelper<ArgumentNullException>(() => { var unused = del(); });
            Assert.AreEqual(paramName, e.ParamName, "Incorrect exception parameter name.");
            return e;
        }

        public static ArgumentOutOfRangeException ExpectArgumentOutOfRangeException(GenericDelegate del, string paramName, string exceptionMessage) {
            ArgumentOutOfRangeException e = ExpectExceptionHelper<ArgumentOutOfRangeException>(del);
            Assert.AreEqual(paramName, e.ParamName, "Incorrect exception parameter name.");
            // Only check exception message on English build and OS, since some exception messages come from the OS
            // and will be in the native language.
            if (exceptionMessage != null) {
                Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            }
            return e;
        }

        public static HttpException ExpectHttpException(GenericDelegate del, string exceptionMessage, int httpCode) {
            HttpException e = ExpectExceptionHelper<HttpException>(del);
            Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            Assert.AreEqual(httpCode, e.GetHttpCode());
            return e;
        }

        public static InvalidOperationException ExpectInvalidOperationException(GenericDelegate del, string exceptionMessage) {
            InvalidOperationException e = ExpectExceptionHelper<InvalidOperationException>(del);
            // Only check exception message on English build and OS, since some exception messages come from the OS
            // and will be in the native language.
            Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            return e;
        }

        public static InvalidOperationException ExpectInvalidOperationException<T>(Func<T> del, string exceptionMessage) {
            InvalidOperationException e = ExpectExceptionHelper<InvalidOperationException>(() => { T unused = del(); });
            // Only check exception message on English build and OS, since some exception messages come from the OS
            // and will be in the native language.
            Assert.AreEqual(exceptionMessage, e.Message, "Incorrect exception message.");
            return e;
        }
    }

    public delegate void GenericDelegate();

    public delegate TReturnType GenericDelegate<TReturnType>();
    public delegate TReturnType GenericDelegate<TReturnType, U>(U u);
    public delegate TReturnType GenericDelegate<TReturnType, U, V>(U u, V v);
    public delegate TReturnType GenericDelegate<TReturnType, U, V, W>(U u, V v, W w);
    public delegate TReturnType GenericDelegate<TReturnType, U, V, W, X>(U u, V v, W w, X x);
    public delegate TReturnType GenericDelegate<TReturnType, U, V, W, X, Y>(U u, V v, W w, X x, Y y);
    public delegate TReturnType GenericDelegate<TReturnType, U, V, W, X, Y, Z>(U u, V v, W w, X x, Y y, Z z);

    public delegate void GenericVoidDelegate<T>(T t);
    public delegate void GenericVoidDelegate<T, U>(T t, U u);
    public delegate void GenericVoidDelegate<T, U, V>(T t, U u, V v);
    public delegate void GenericVoidDelegate<T, U, V, W>(T t, U u, V v, W w);
    public delegate void GenericVoidDelegate<T, U, V, W, X>(T t, U u, V v, W w, X x);
    public delegate void GenericVoidDelegate<T, U, V, W, X, Y>(T t, U u, V v, W w, X x, Y y);
    public delegate void GenericVoidDelegate<T, U, V, W, X, Y, Z>(T t, U u, V v, W w, X x, Y y, Z z);
}
