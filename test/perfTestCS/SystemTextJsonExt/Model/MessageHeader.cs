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
  /// JSON Serialization Extensions for MessageHeader
  /// </summary>
  public static class MessageHeaderJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MessageHeader into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MessageHeader");
      // Complex: MessageHeader, Export: MessageHeader, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Event != null)
      {
        switch (current.Event)
        {
          case Coding v_Coding:
            writer.WritePropertyName("eventCoding");
            v_Coding.SerializeJson(writer, options);
            break;
          case FhirUri v_FhirUri:
            writer.WriteString("eventUri",v_FhirUri.Value);
            break;
        }
      }
      if ((current.Destination != null) && (current.Destination.Count != 0))
      {
        writer.WritePropertyName("destination");
        writer.WriteStartArray();
        foreach (MessageHeader.MessageDestinationComponent val in current.Destination)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Sender != null)
      {
        writer.WritePropertyName("sender");
        current.Sender.SerializeJson(writer, options);
      }

      if (current.Enterer != null)
      {
        writer.WritePropertyName("enterer");
        current.Enterer.SerializeJson(writer, options);
      }

      if (current.Author != null)
      {
        writer.WritePropertyName("author");
        current.Author.SerializeJson(writer, options);
      }

      writer.WritePropertyName("source");
      current.Source.SerializeJson(writer, options);

      if (current.Responsible != null)
      {
        writer.WritePropertyName("responsible");
        current.Responsible.SerializeJson(writer, options);
      }

      if (current.Reason != null)
      {
        writer.WritePropertyName("reason");
        current.Reason.SerializeJson(writer, options);
      }

      if (current.Response != null)
      {
        writer.WritePropertyName("response");
        current.Response.SerializeJson(writer, options);
      }

      if ((current.Focus != null) && (current.Focus.Count != 0))
      {
        writer.WritePropertyName("focus");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Focus)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.DefinitionElement != null) && (current.DefinitionElement.Value != null))
      {
        writer.WriteString("definition",current.DefinitionElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader
    /// </summary>
    public static void DeserializeJson(this MessageHeader current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MessageHeader
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "eventCoding":
          current.Event = JsonSerializer.Deserialize<Hl7.Fhir.Model.Coding>(ref reader, options);
          break;

        case "eventUri":
          current.Event = new FhirUri(reader.GetString());
          break;

        case "destination":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Destination = new List<MessageHeader.MessageDestinationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Destination.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Destination.Count == 0)
          {
            current.Destination = null;
          }

          break;

        case "sender":
          current.Sender = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "enterer":
          current.Enterer = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "author":
          current.Author = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "source":
          current.Source = JsonSerializer.Deserialize<Hl7.Fhir.Model.MessageHeader.MessageSourceComponent>(ref reader, options);

          break;

        case "responsible":
          current.Responsible = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "reason":
          current.Reason = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "response":
          current.Response = JsonSerializer.Deserialize<Hl7.Fhir.Model.MessageHeader.ResponseComponent>(ref reader, options);

          break;

        case "focus":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Focus = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Focus.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Focus.Count == 0)
          {
            current.Focus = null;
          }

          break;

        case "definition":
          current.DefinitionElement = new Canonical(reader.GetString());

          break;

        // Complex: MessageHeader, Export: MessageHeader, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#MessageDestination into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.MessageDestinationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#MessageDestination, Export: MessageDestinationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.NameElement != null) && (current.NameElement.Value != null))
      {
        writer.WriteString("name",current.NameElement.Value);
      }

      if (current.Target != null)
      {
        writer.WritePropertyName("target");
        current.Target.SerializeJson(writer, options);
      }

      writer.WriteString("endpoint",current.EndpointElement.Value);

      if (current.Receiver != null)
      {
        writer.WritePropertyName("receiver");
        current.Receiver.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageDestination
    /// </summary>
    public static void DeserializeJson(this MessageHeader.MessageDestinationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MessageHeader#MessageDestination
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.MessageDestinationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "name":
          current.NameElement = new FhirString(reader.GetString());

          break;

        case "target":
          current.Target = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "endpoint":
          current.EndpointElement = new FhirUrl(reader.GetString());

          break;

        case "receiver":
          current.Receiver = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        // Complex: destination, Export: MessageDestinationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#MessageSource into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.MessageSourceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#MessageSource, Export: MessageSourceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.NameElement != null) && (current.NameElement.Value != null))
      {
        writer.WriteString("name",current.NameElement.Value);
      }

      if ((current.SoftwareElement != null) && (current.SoftwareElement.Value != null))
      {
        writer.WriteString("software",current.SoftwareElement.Value);
      }

      if ((current.VersionElement != null) && (current.VersionElement.Value != null))
      {
        writer.WriteString("version",current.VersionElement.Value);
      }

      if (current.Contact != null)
      {
        writer.WritePropertyName("contact");
        current.Contact.SerializeJson(writer, options);
      }

      writer.WriteString("endpoint",current.EndpointElement.Value);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageSource
    /// </summary>
    public static void DeserializeJson(this MessageHeader.MessageSourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MessageHeader#MessageSource
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.MessageSourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "name":
          current.NameElement = new FhirString(reader.GetString());

          break;

        case "software":
          current.SoftwareElement = new FhirString(reader.GetString());

          break;

        case "version":
          current.VersionElement = new FhirString(reader.GetString());

          break;

        case "contact":
          current.Contact = JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactPoint>(ref reader, options);

          break;

        case "endpoint":
          current.EndpointElement = new FhirUrl(reader.GetString());

          break;

        // Complex: source, Export: MessageSourceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#Response into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.ResponseComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#Response, Export: ResponseComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("identifier",current.IdentifierElement.Value);

      writer.WriteString("code",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.CodeElement.Value));

      if (current.Details != null)
      {
        writer.WritePropertyName("details");
        current.Details.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#Response
    /// </summary>
    public static void DeserializeJson(this MessageHeader.ResponseComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MessageHeader#Response
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.ResponseComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.IdentifierElement = new Id(reader.GetString());

          break;

        case "code":
          current.CodeElement =new Code<Hl7.Fhir.Model.MessageHeader.ResponseType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.MessageHeader.ResponseType>(reader.GetString()));

          break;

        case "details":
          current.Details = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        // Complex: response, Export: ResponseComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MessageHeaderJsonConverter : JsonConverter<MessageHeader>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(MessageHeader).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MessageHeader value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MessageHeader Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MessageHeader target = new MessageHeader();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
