/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{

    /// <summary>
    /// A three dimensional vector.
    /// </summary>
    public class Vector3 : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Vector3(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector3 obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;

        ~Vector3()
        {
            if(!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Vector3(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            disposed = true;
        }

        /// <summary>
        /// Addition operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the addition</returns>
        public static Vector3 operator +(Vector3 arg1, Vector3 arg2)
        {
            return arg1.Add(arg2);
        }

        /// <summary>
        /// Subtraction operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the subtraction</returns>
        public static Vector3 operator -(Vector3 arg1, Vector3 arg2)
        {
            return arg1.Subtract(arg2);
        }

        /// <summary>
        /// Unary negation operator.
        /// </summary>
        /// <param name="arg1">Target Value</param>
        /// <returns>A vector containg the negation</returns>
        public static Vector3 operator -(Vector3 arg1)
        {
            return arg1.Subtract();
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the multiplication</returns>
        public static Vector3 operator *(Vector3 arg1, Vector3 arg2)
        {
            return arg1.Multiply(arg2);
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">The float value to scale the vector</param>
        /// <returns>A vector containing the result of the scaling</returns>
        public static Vector3 operator *(Vector3 arg1, float arg2)
        {
            return arg1.Multiply(arg2);
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the division</returns>
        public static Vector3 operator /(Vector3 arg1, Vector3 arg2)
        {
            return arg1.Divide(arg2);
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">The float value to scale the vector by</param>
        /// <returns>A vector containing the result of the scaling</returns>
        public static Vector3 operator /(Vector3 arg1, float arg2)
        {
            return arg1.Divide(arg2);
        }

        /// <summary>
        /// Array subscript operator overload.
        /// </summary>
        /// <param name="index">Subscript index</param>
        /// <returns>The float at the given index</returns>
        public float this[uint index]
        {
            get
            {
                return ValueOfIndex(index);
            }
        }

        internal static Vector3 GetVector3FromPtr(global::System.IntPtr cPtr)
        {
            Vector3 ret = new Vector3(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Vector3() : this(NDalicPINVOKE.new_Vector3__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Default constructor, initializes the vector to 0.
        /// </summary>
        /// <param name="x">x (or width) component</param>
        /// <param name="y">y (or height) component</param>
        /// <param name="z">z (or depth) component</param>
        public Vector3(float x, float y, float z) : this(NDalicPINVOKE.new_Vector3__SWIG_1(x, y, z), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from an array of three floats.
        /// </summary>
        /// <param name="array">Array of xyz</param>
        public Vector3(float[] array) : this(NDalicPINVOKE.new_Vector3__SWIG_2(array), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="vec2">Vector2 to create this vector from</param>
        public Vector3(Vector2 vec2) : this(NDalicPINVOKE.new_Vector3__SWIG_3(Vector2.getCPtr(vec2)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vec4">Vector4 to create this vector from</param>
        public Vector3(Vector4 vec4) : this(NDalicPINVOKE.new_Vector3__SWIG_4(Vector4.getCPtr(vec4)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// (1.0f,1.0f,1.0f)
        /// </summary>
        public static Vector3 One
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_ONE_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the X axis
        /// </summary>
        public static Vector3 XAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_XAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the Y axis
        /// </summary>
        public static Vector3 YAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_YAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the Z axis
        /// </summary>
        public static Vector3 ZAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_ZAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the negative X axis
        /// </summary>
        public static Vector3 NegativeXAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_NEGATIVE_XAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the negative Y axis
        /// </summary>
        public static Vector3 NegativeYAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_NEGATIVE_YAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Vector representing the negative Z axis
        /// </summary>
        public static Vector3 NegativeZAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_NEGATIVE_ZAXIS_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// (0.0f, 0.0f, 0.0f)
        /// </summary>
        public static Vector3 Zero
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_ZERO_get();
                Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private Vector3 Add(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Add(swigCPtr, Vector3.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 AddAssign(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_AddAssign(swigCPtr, Vector3.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Subtract(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Subtract__SWIG_0(swigCPtr, Vector3.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 SubtractAssign(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_SubtractAssign(swigCPtr, Vector3.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Multiply(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Multiply__SWIG_0(swigCPtr, Vector3.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Multiply(float rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Multiply__SWIG_1(swigCPtr, rhs), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 MultiplyAssign(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_MultiplyAssign__SWIG_0(swigCPtr, Vector3.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 MultiplyAssign(float rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_MultiplyAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 MultiplyAssign(Rotation rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_MultiplyAssign__SWIG_2(swigCPtr, Rotation.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Divide(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Divide__SWIG_0(swigCPtr, Vector3.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Divide(float rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Divide__SWIG_1(swigCPtr, rhs), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 DivideAssign(Vector3 rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_DivideAssign__SWIG_0(swigCPtr, Vector3.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 DivideAssign(float rhs)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_DivideAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector3 Subtract()
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Subtract__SWIG_1(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool EqualTo(Vector3 rhs)
        {
            bool ret = NDalicPINVOKE.Vector3_EqualTo(swigCPtr, Vector3.getCPtr(rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool NotEqualTo(Vector3 rhs)
        {
            bool ret = NDalicPINVOKE.Vector3_NotEqualTo(swigCPtr, Vector3.getCPtr(rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private float ValueOfIndex(uint index)
        {
            float ret = NDalicPINVOKE.Vector3_ValueOfIndex__SWIG_0(swigCPtr, index);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot(Vector3 other)
        {
            float ret = NDalicPINVOKE.Vector3_Dot(swigCPtr, Vector3.getCPtr(other));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Vector3 Cross(Vector3 other)
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.Vector3_Cross(swigCPtr, Vector3.getCPtr(other)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the length of the vector.
        /// </summary>
        /// <returns>The length of the vector</returns>
        public float Length()
        {
            float ret = NDalicPINVOKE.Vector3_Length(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the length of the vector squared.<br>
        /// This is more efficient than Length() for threshold
        /// testing as it avoids the use of a square root.<br>
        /// </summary>
        /// <returns>The length of the vector squared</returns>
        public float LengthSquared()
        {
            float ret = NDalicPINVOKE.Vector3_LengthSquared(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Sets the vector to be unit length, whilst maintaining its direction.
        /// </summary>
        public void Normalize()
        {
            NDalicPINVOKE.Vector3_Normalize(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Clamps the vector between minimum and maximum vectors.
        /// </summary>
        /// <param name="min">The minimum vector</param>
        /// <param name="max">The maximum vector</param>
        public void Clamp(Vector3 min, Vector3 max)
        {
            NDalicPINVOKE.Vector3_Clamp(swigCPtr, Vector3.getCPtr(min), Vector3.getCPtr(max));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal SWIGTYPE_p_float AsFloat()
        {
            global::System.IntPtr cPtr = NDalicPINVOKE.Vector3_AsFloat__SWIG_0(swigCPtr);
            SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the x & y components (or width & height, or r & g) as a Vector2.
        /// </summary>
        /// <returns>The partial vector contents as Vector2 (x,y)</returns>
        public Vector2 GetVectorXY()
        {
            Vector2 ret = new Vector2(NDalicPINVOKE.Vector3_GetVectorXY__SWIG_0(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the y & z components (or height & depth, or g & b) as a Vector2.
        /// </summary>
        /// <returns>The partial vector contents as Vector2 (y,z)</returns>
        public Vector2 GetVectorYZ()
        {
            Vector2 ret = new Vector2(NDalicPINVOKE.Vector3_GetVectorYZ__SWIG_0(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// x component
        /// </summary>
        public float X
        {
            set
            {
                NDalicPINVOKE.Vector3_X_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_X_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// width component
        /// </summary>
        public float Width
        {
            set
            {
                NDalicPINVOKE.Vector3_Width_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_Width_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// red component
        /// </summary>
        public float R
        {
            set
            {
                NDalicPINVOKE.Vector3_r_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_r_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// y component
        /// </summary>
        public float Y
        {
            set
            {
                NDalicPINVOKE.Vector3_Y_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_Y_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// height component
        /// </summary>
        public float Height
        {
            set
            {
                NDalicPINVOKE.Vector3_Height_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_Height_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// green component
        /// </summary>
        public float G
        {
            set
            {
                NDalicPINVOKE.Vector3_g_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_g_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// z component
        /// </summary>
        public float Z
        {
            set
            {
                NDalicPINVOKE.Vector3_Z_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_Z_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// depth component
        /// </summary>
        public float Depth
        {
            set
            {
                NDalicPINVOKE.Vector3_Depth_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_Depth_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// blue component
        /// </summary>
        public float B
        {
            set
            {
                NDalicPINVOKE.Vector3_b_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector3_b_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

    }

}