/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2016 IT Adapter Inc.
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
</FILE_LICENSE>*/
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace NFX.Serialization.POD
{

  /// <summary>
  /// Base exception thrown by the Portable Object Document serialization format
  /// </summary>
  [Serializable]
  public class PODException : NFXSerializationException
  {
    public PODException()
    {
    }

    public PODException(string message)
      : base(message)
    {
    }

    public PODException(string message, Exception inner)
      : base(message, inner)
    {
    }

    protected PODException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {

    }

  }


  /// <summary>
  /// Base exception thrown by the PortableObjectDocument when serializing objects into document
  /// </summary>
  [Serializable]
  public class PODSerializationException : PODException
  {
    public PODSerializationException()
    {
    }

    public PODSerializationException(string message)
      : base(message)
    {
    }

    public PODSerializationException(string message, Exception inner)
      : base(message, inner)
    {
    }

    protected PODSerializationException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {

    }

  }


  /// <summary>
  /// Base exception thrown by the PortableObjectDocument when deserializing original objects
  /// </summary>
  [Serializable]
  public class PODDeserializationException : PODException
  {
    public PODDeserializationException()
    {
    }

    public PODDeserializationException(string message)
      : base(message)
    {
    }

    public PODDeserializationException(string message, Exception inner)
      : base(message, inner)
    {
    }

    protected PODDeserializationException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {

    }

  }

}