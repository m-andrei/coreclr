// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\General\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace JIT.HardwareIntrinsics.General
{
    public static partial class Program
    {
        private static void AsByte()
        {
            var test = new VectorAs__AsByte();

            // Validates basic functionality works
            test.RunBasicScenario();

            // Validates basic functionality works using the generic form, rather than the type-specific form of the method
            test.RunGenericScenario();

            // Validates calling via reflection works
            test.RunReflectionScenario();

            if (!test.Succeeded)
            {
                throw new Exception("One or more scenarios did not complete as expected.");
            }
        }
    }

    public sealed unsafe class VectorAs__AsByte
    {
        private static readonly int LargestVectorSize = 16;

        private static readonly int ElementCount = Unsafe.SizeOf<Vector128<Byte>>() / sizeof(Byte);

        public bool Succeeded { get; set; } = true;

        public void RunBasicScenario()
        {
            TestLibrary.TestFramework.BeginScenario(nameof(RunBasicScenario));
            Vector128<Byte> value;

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<byte> byteResult = value.AsByte();
            ValidateResult(byteResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<double> doubleResult = value.AsDouble();
            ValidateResult(doubleResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<short> shortResult = value.AsInt16();
            ValidateResult(shortResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<int> intResult = value.AsInt32();
            ValidateResult(intResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<long> longResult = value.AsInt64();
            ValidateResult(longResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<sbyte> sbyteResult = value.AsSByte();
            ValidateResult(sbyteResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<float> floatResult = value.AsSingle();
            ValidateResult(floatResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<ushort> ushortResult = value.AsUInt16();
            ValidateResult(ushortResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<uint> uintResult = value.AsUInt32();
            ValidateResult(uintResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<ulong> ulongResult = value.AsUInt64();
            ValidateResult(ulongResult, value);
        }

        public void RunGenericScenario()
        {
            TestLibrary.TestFramework.BeginScenario(nameof(RunGenericScenario));
            Vector128<Byte> value;

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<byte> byteResult = value.As<byte>();
            ValidateResult(byteResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<double> doubleResult = value.As<double>();
            ValidateResult(doubleResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<short> shortResult = value.As<short>();
            ValidateResult(shortResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<int> intResult = value.As<int>();
            ValidateResult(intResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<long> longResult = value.As<long>();
            ValidateResult(longResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<sbyte> sbyteResult = value.As<sbyte>();
            ValidateResult(sbyteResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<float> floatResult = value.As<float>();
            ValidateResult(floatResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<ushort> ushortResult = value.As<ushort>();
            ValidateResult(ushortResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<uint> uintResult = value.As<uint>();
            ValidateResult(uintResult, value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            Vector128<ulong> ulongResult = value.As<ulong>();
            ValidateResult(ulongResult, value);
        }

        public void RunReflectionScenario()
        {
            TestLibrary.TestFramework.BeginScenario(nameof(RunReflectionScenario));
            Vector128<Byte> value;

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object byteResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsByte), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<byte>)(byteResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object doubleResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsDouble), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<double>)(doubleResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object shortResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsInt16), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<short>)(shortResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object intResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsInt32), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<int>)(intResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object longResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsInt64), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<long>)(longResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object sbyteResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsSByte), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<sbyte>)(sbyteResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object floatResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsSingle), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<float>)(floatResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object ushortResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsUInt16), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<ushort>)(ushortResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object uintResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsUInt32), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<uint>)(uintResult), value);

            value = Vector128.Create(TestLibrary.Generator.GetByte());
            object ulongResult = typeof(Vector128<Byte>)
                                    .GetMethod(nameof(Vector128<Byte>.AsUInt64), new Type[] { })
                                    .Invoke(value, new object[] { });
            ValidateResult((Vector128<ulong>)(ulongResult), value);
        }

        private void ValidateResult<T>(Vector128<T> result, Vector128<Byte> value, [CallerMemberName] string method = "")
            where T : struct
        {
            Byte[] resultElements = new Byte[ElementCount];
            Unsafe.WriteUnaligned(ref Unsafe.As<Byte, byte>(ref resultElements[0]), result);

            Byte[] valueElements = new Byte[ElementCount];
            Unsafe.WriteUnaligned(ref Unsafe.As<Byte, byte>(ref valueElements[0]), value);

            ValidateResult(resultElements, valueElements, typeof(T), method);
        }

        private void ValidateResult(Byte[] resultElements, Byte[] valueElements, Type targetType, [CallerMemberName] string method = "")
        {
            bool succeeded = true;

            for (var i = 0; i < ElementCount; i++)
            {
                if (resultElements[i] != valueElements[i])
                {
                    succeeded = false;
                    break;
                }
            }

            if (!succeeded)
            {
                TestLibrary.TestFramework.LogInformation($"Vector128<Byte>.As{targetType.Name}: {method} failed:");
                TestLibrary.TestFramework.LogInformation($"   value: ({string.Join(", ", valueElements)})");
                TestLibrary.TestFramework.LogInformation($"  result: ({string.Join(", ", resultElements)})");
                TestLibrary.TestFramework.LogInformation(string.Empty);

                Succeeded = false;
            }
        }
    }
}
