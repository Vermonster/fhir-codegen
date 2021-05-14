// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Attachment
  /// </summary>
  public static class AttachmentJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Attachment into JSON
    /// </summary>
    public static void SerializeJson(this Attachment current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if ((current.ContentTypeElement != null) && (current.ContentTypeElement.Value != null))
      {
        writer.WriteString("contentType",current.ContentTypeElement.Value);
      }

      if ((current.LanguageElement != null) && (current.LanguageElement.Value != null))
      {
        writer.WriteString("language",current.LanguageElement.Value);
      }

      if ((current.DataElement != null) && (current.DataElement.Value != null))
      {
        writer.WriteBase64String("data",current.DataElement.Value);
      }

      if ((current.UrlElement != null) && (current.UrlElement.Value != null))
      {
        writer.WriteString("url",current.UrlElement.Value);
      }

      if ((current.SizeElement != null) && (current.SizeElement.Value != null))
      {
        writer.WriteNumber("size",(int)current.SizeElement.Value);
      }

      if ((current.HashElement != null) && (current.HashElement.Value != null))
      {
        writer.WriteBase64String("hash",current.HashElement.Value);
      }

      if ((current.TitleElement != null) && (current.TitleElement.Value != null))
      {
        writer.WriteString("title",current.TitleElement.Value);
      }

      if ((current.CreationElement != null) && (current.CreationElement.Value != null))
      {
        writer.WriteString("creation",current.CreationElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Attachment
    /// </summary>
    public static void DeserializeJson(this Attachment current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Attachment
    /// </summary>
    public static void DeserializeJsonProperty(this Attachment current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "contentType":
          current.ContentTypeElement = new Code(reader.GetString());

          break;

        case "language":
          current.LanguageElement = new Code(reader.GetString());

          break;

        case "data":
          current.DataElement = new Base64Binary(reader.GetBytesFromBase64());

          break;

        case "url":
          current.UrlElement = new FhirUrl(reader.GetString());

          break;

        case "size":
          current.SizeElement = new UnsignedInt(reader.GetInt32());

          break;

        case "hash":
          current.HashElement = new Base64Binary(reader.GetBytesFromBase64());

          break;

        case "title":
          current.TitleElement = new FhirString(reader.GetString());

          break;

        case "creation":
          current.CreationElement = new FhirDateTime(reader.GetString());

          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AttachmentJsonConverter : JsonConverter<Attachment>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Attachment).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Attachment value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Attachment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Attachment target = new Attachment();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
