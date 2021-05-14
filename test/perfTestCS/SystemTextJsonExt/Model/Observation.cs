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
  /// JSON Serialization Extensions for Observation
  /// </summary>
  public static class ObservationJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Observation into JSON
    /// </summary>
    public static void SerializeJson(this Observation current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Observation");
      // Complex: Observation, Export: Observation, Base: DomainResource (DomainResource)
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

      if ((current.BasedOn != null) && (current.BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.BasedOn)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PartOf != null) && (current.PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.PartOf)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

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

      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
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

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.Effective != null)
      {
        switch (current.Effective)
        {
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("effectiveDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("effectivePeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Timing v_Timing:
            writer.WritePropertyName("effectiveTiming");
            v_Timing.SerializeJson(writer, options);
            break;
          case Instant v_Instant:
            writer.WriteString("effectiveInstant",((DateTimeOffset)v_Instant.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK", System.Globalization.CultureInfo.InvariantCulture));
            break;
        }
      }
      if ((current.IssuedElement != null) && (current.IssuedElement.Value != null))
      {
        writer.WriteString("issued",((DateTimeOffset)current.IssuedElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK", System.Globalization.CultureInfo.InvariantCulture));
      }

      if ((current.Performer != null) && (current.Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Performer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case Quantity v_Quantity:
            writer.WritePropertyName("valueQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("valueCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case FhirString v_FhirString:
            writer.WriteString("valueString",v_FhirString.Value);
            break;
          case FhirBoolean v_FhirBoolean:
            writer.WriteBoolean("valueBoolean", (bool)v_FhirBoolean.Value);
            break;
          case Integer v_Integer:
            writer.WriteNumber("valueInteger",(int)v_Integer.Value);
            break;
          case Range v_Range:
            writer.WritePropertyName("valueRange");
            v_Range.SerializeJson(writer, options);
            break;
          case Ratio v_Ratio:
            writer.WritePropertyName("valueRatio");
            v_Ratio.SerializeJson(writer, options);
            break;
          case SampledData v_SampledData:
            writer.WritePropertyName("valueSampledData");
            v_SampledData.SerializeJson(writer, options);
            break;
          case Time v_Time:
            writer.WritePropertyName("valueTime");
            v_Time.SerializeJson(writer, options);
            break;
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("valueDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("valuePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (current.DataAbsentReason != null)
      {
        writer.WritePropertyName("dataAbsentReason");
        current.DataAbsentReason.SerializeJson(writer, options);
      }

      if ((current.Interpretation != null) && (current.Interpretation.Count != 0))
      {
        writer.WritePropertyName("interpretation");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Interpretation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Note != null) && (current.Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();
        foreach (Annotation val in current.Note)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.BodySite != null)
      {
        writer.WritePropertyName("bodySite");
        current.BodySite.SerializeJson(writer, options);
      }

      if (current.Method != null)
      {
        writer.WritePropertyName("method");
        current.Method.SerializeJson(writer, options);
      }

      if (current.Specimen != null)
      {
        writer.WritePropertyName("specimen");
        current.Specimen.SerializeJson(writer, options);
      }

      if (current.Device != null)
      {
        writer.WritePropertyName("device");
        current.Device.SerializeJson(writer, options);
      }

      if ((current.ReferenceRange != null) && (current.ReferenceRange.Count != 0))
      {
        writer.WritePropertyName("referenceRange");
        writer.WriteStartArray();
        foreach (Observation.ReferenceRangeComponent val in current.ReferenceRange)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.HasMember != null) && (current.HasMember.Count != 0))
      {
        writer.WritePropertyName("hasMember");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.HasMember)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.DerivedFrom != null) && (current.DerivedFrom.Count != 0))
      {
        writer.WritePropertyName("derivedFrom");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.DerivedFrom)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Component != null) && (current.Component.Count != 0))
      {
        writer.WritePropertyName("component");
        writer.WriteStartArray();
        foreach (Observation.ComponentComponent val in current.Component)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Observation
    /// </summary>
    public static void DeserializeJson(this Observation current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Observation
    /// </summary>
    public static void DeserializeJsonProperty(this Observation current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
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

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.BasedOn.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }

          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PartOf = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.PartOf.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.PartOf.Count == 0)
          {
            current.PartOf = null;
          }

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.ObservationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ObservationStatus>(reader.GetString()));

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

        case "subject":
          current.Subject = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

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

        case "encounter":
          current.Encounter = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "effectiveDateTime":
          current.Effective = new FhirDateTime(reader.GetString());
          break;

        case "effectivePeriod":
          current.Effective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "effectiveTiming":
          current.Effective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Timing>(ref reader, options);
          break;

        case "effectiveInstant":
          current.Effective = new Instant(DateTimeOffset.Parse(reader.GetString()));
          break;

        case "issued":
          current.IssuedElement = new Instant(DateTimeOffset.Parse(reader.GetString()));

          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Performer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Performer.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Performer.Count == 0)
          {
            current.Performer = null;
          }

          break;

        case "valueQuantity":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);
          break;

        case "valueCodeableConcept":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "valueString":
          current.Value = new FhirString(reader.GetString());
          break;

        case "valueBoolean":
          current.Value = new FhirBoolean(reader.GetBoolean());
          break;

        case "valueInteger":
          current.Value = new Integer(reader.GetInt32());
          break;

        case "valueRange":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Range>(ref reader, options);
          break;

        case "valueRatio":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);
          break;

        case "valueSampledData":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.SampledData>(ref reader, options);
          break;

        case "valueTime":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Time>(ref reader, options);
          break;

        case "valueDateTime":
          current.Value = new FhirDateTime(reader.GetString());
          break;

        case "valuePeriod":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "dataAbsentReason":
          current.DataAbsentReason = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "interpretation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Interpretation = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Interpretation.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Interpretation.Count == 0)
          {
            current.Interpretation = null;
          }

          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Note.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Annotation>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }

          break;

        case "bodySite":
          current.BodySite = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "method":
          current.Method = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "specimen":
          current.Specimen = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "device":
          current.Device = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "referenceRange":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReferenceRange = new List<Observation.ReferenceRangeComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReferenceRange.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Observation.ReferenceRangeComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReferenceRange.Count == 0)
          {
            current.ReferenceRange = null;
          }

          break;

        case "hasMember":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.HasMember = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.HasMember.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.HasMember.Count == 0)
          {
            current.HasMember = null;
          }

          break;

        case "derivedFrom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DerivedFrom = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DerivedFrom.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DerivedFrom.Count == 0)
          {
            current.DerivedFrom = null;
          }

          break;

        case "component":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Component = new List<Observation.ComponentComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Component.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Observation.ComponentComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Component.Count == 0)
          {
            current.Component = null;
          }

          break;

        // Complex: Observation, Export: Observation, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Observation#ReferenceRange into JSON
    /// </summary>
    public static void SerializeJson(this Observation.ReferenceRangeComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Observation#ReferenceRange, Export: ReferenceRangeComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Low != null)
      {
        writer.WritePropertyName("low");
        current.Low.SerializeJson(writer, options);
      }

      if (current.High != null)
      {
        writer.WritePropertyName("high");
        current.High.SerializeJson(writer, options);
      }

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if ((current.AppliesTo != null) && (current.AppliesTo.Count != 0))
      {
        writer.WritePropertyName("appliesTo");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.AppliesTo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Age != null)
      {
        writer.WritePropertyName("age");
        current.Age.SerializeJson(writer, options);
      }

      if ((current.TextElement != null) && (current.TextElement.Value != null))
      {
        writer.WriteString("text",current.TextElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Observation#ReferenceRange
    /// </summary>
    public static void DeserializeJson(this Observation.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Observation#ReferenceRange
    /// </summary>
    public static void DeserializeJsonProperty(this Observation.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "low":
          current.Low = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        case "high":
          current.High = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        case "type":
          current.Type = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "appliesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.AppliesTo = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.AppliesTo.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.AppliesTo.Count == 0)
          {
            current.AppliesTo = null;
          }

          break;

        case "age":
          current.Age = JsonSerializer.Deserialize<Hl7.Fhir.Model.Range>(ref reader, options);

          break;

        case "text":
          current.TextElement = new FhirString(reader.GetString());

          break;

        // Complex: referenceRange, Export: ReferenceRangeComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Observation#Component into JSON
    /// </summary>
    public static void SerializeJson(this Observation.ComponentComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Observation#Component, Export: ComponentComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case Quantity v_Quantity:
            writer.WritePropertyName("valueQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("valueCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case FhirString v_FhirString:
            writer.WriteString("valueString",v_FhirString.Value);
            break;
          case FhirBoolean v_FhirBoolean:
            writer.WriteBoolean("valueBoolean", (bool)v_FhirBoolean.Value);
            break;
          case Integer v_Integer:
            writer.WriteNumber("valueInteger",(int)v_Integer.Value);
            break;
          case Range v_Range:
            writer.WritePropertyName("valueRange");
            v_Range.SerializeJson(writer, options);
            break;
          case Ratio v_Ratio:
            writer.WritePropertyName("valueRatio");
            v_Ratio.SerializeJson(writer, options);
            break;
          case SampledData v_SampledData:
            writer.WritePropertyName("valueSampledData");
            v_SampledData.SerializeJson(writer, options);
            break;
          case Time v_Time:
            writer.WritePropertyName("valueTime");
            v_Time.SerializeJson(writer, options);
            break;
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("valueDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("valuePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (current.DataAbsentReason != null)
      {
        writer.WritePropertyName("dataAbsentReason");
        current.DataAbsentReason.SerializeJson(writer, options);
      }

      if ((current.Interpretation != null) && (current.Interpretation.Count != 0))
      {
        writer.WritePropertyName("interpretation");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Interpretation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReferenceRange != null) && (current.ReferenceRange.Count != 0))
      {
        writer.WritePropertyName("referenceRange");
        writer.WriteStartArray();
        foreach (Observation.ReferenceRangeComponent val in current.ReferenceRange)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Observation#Component
    /// </summary>
    public static void DeserializeJson(this Observation.ComponentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Observation#Component
    /// </summary>
    public static void DeserializeJsonProperty(this Observation.ComponentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "valueQuantity":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);
          break;

        case "valueCodeableConcept":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "valueString":
          current.Value = new FhirString(reader.GetString());
          break;

        case "valueBoolean":
          current.Value = new FhirBoolean(reader.GetBoolean());
          break;

        case "valueInteger":
          current.Value = new Integer(reader.GetInt32());
          break;

        case "valueRange":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Range>(ref reader, options);
          break;

        case "valueRatio":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);
          break;

        case "valueSampledData":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.SampledData>(ref reader, options);
          break;

        case "valueTime":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Time>(ref reader, options);
          break;

        case "valueDateTime":
          current.Value = new FhirDateTime(reader.GetString());
          break;

        case "valuePeriod":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "dataAbsentReason":
          current.DataAbsentReason = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "interpretation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Interpretation = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Interpretation.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Interpretation.Count == 0)
          {
            current.Interpretation = null;
          }

          break;

        case "referenceRange":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReferenceRange = new List<Observation.ReferenceRangeComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReferenceRange.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Observation.ReferenceRangeComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReferenceRange.Count == 0)
          {
            current.ReferenceRange = null;
          }

          break;

        // Complex: component, Export: ComponentComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ObservationJsonConverter : JsonConverter<Observation>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Observation).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Observation value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Observation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Observation target = new Observation();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
