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
  /// JSON Serialization Extensions for Substance
  /// </summary>
  public static class SubstanceJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Substance into JSON
    /// </summary>
    public static void SerializeJson(this Substance current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Substance");
      // Complex: Substance, Export: Substance, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.StatusElement != null)
      {
        writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));
      }

      if ((current.Category != null) && (current.Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Category)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      if ((current.Instance != null) && (current.Instance.Count != 0))
      {
        writer.WritePropertyName("instance");
        writer.WriteStartArray();
        foreach (Substance.InstanceComponent val in current.Instance)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Ingredient != null) && (current.Ingredient.Count != 0))
      {
        writer.WritePropertyName("ingredient");
        writer.WriteStartArray();
        foreach (Substance.IngredientComponent val in current.Ingredient)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Substance
    /// </summary>
    public static void DeserializeJson(this Substance current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Substance
    /// </summary>
    public static void DeserializeJsonProperty(this Substance current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Identifier.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.Substance.FHIRSubstanceStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Substance.FHIRSubstanceStatus>(reader.GetString()));

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Category.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }

          break;

        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());

          break;

        case "instance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Instance = new List<Substance.InstanceComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Instance.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Substance.InstanceComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Instance.Count == 0)
          {
            current.Instance = null;
          }

          break;

        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Ingredient = new List<Substance.IngredientComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Ingredient.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Substance.IngredientComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Ingredient.Count == 0)
          {
            current.Ingredient = null;
          }

          break;

        // Complex: Substance, Export: Substance, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Substance#Instance into JSON
    /// </summary>
    public static void SerializeJson(this Substance.InstanceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Substance#Instance, Export: InstanceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Identifier != null)
      {
        writer.WritePropertyName("identifier");
        current.Identifier.SerializeJson(writer, options);
      }

      if ((current.ExpiryElement != null) && (current.ExpiryElement.Value != null))
      {
        writer.WriteString("expiry",current.ExpiryElement.Value);
      }

      if (current.Quantity != null)
      {
        writer.WritePropertyName("quantity");
        current.Quantity.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Substance#Instance
    /// </summary>
    public static void DeserializeJson(this Substance.InstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Substance#Instance
    /// </summary>
    public static void DeserializeJsonProperty(this Substance.InstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.Identifier = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "expiry":
          current.ExpiryElement = new FhirDateTime(reader.GetString());

          break;

        case "quantity":
          current.Quantity = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        // Complex: instance, Export: InstanceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Substance#Ingredient into JSON
    /// </summary>
    public static void SerializeJson(this Substance.IngredientComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Substance#Ingredient, Export: IngredientComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Quantity != null)
      {
        writer.WritePropertyName("quantity");
        current.Quantity.SerializeJson(writer, options);
      }

      if (current.Substance != null)
      {
        switch (current.Substance)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("substanceCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("substanceReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Substance#Ingredient
    /// </summary>
    public static void DeserializeJson(this Substance.IngredientComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Substance#Ingredient
    /// </summary>
    public static void DeserializeJsonProperty(this Substance.IngredientComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "quantity":
          current.Quantity = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "substanceCodeableConcept":
          current.Substance = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "substanceReference":
          current.Substance = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);
          break;

        // Complex: ingredient, Export: IngredientComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstanceJsonConverter : JsonConverter<Substance>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Substance).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Substance value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Substance Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Substance target = new Substance();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
