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
  /// JSON Serialization Extensions for DiagnosticReport
  /// </summary>
  public static class DiagnosticReportJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR DiagnosticReport into JSON
    /// </summary>
    public static void SerializeJson(this DiagnosticReport current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","DiagnosticReport");
      // Complex: DiagnosticReport, Export: DiagnosticReport, Base: DomainResource (DomainResource)
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

      if ((current.ResultsInterpreter != null) && (current.ResultsInterpreter.Count != 0))
      {
        writer.WritePropertyName("resultsInterpreter");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ResultsInterpreter)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Specimen != null) && (current.Specimen.Count != 0))
      {
        writer.WritePropertyName("specimen");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Specimen)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Result != null) && (current.Result.Count != 0))
      {
        writer.WritePropertyName("result");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Result)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ImagingStudy != null) && (current.ImagingStudy.Count != 0))
      {
        writer.WritePropertyName("imagingStudy");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ImagingStudy)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Media != null) && (current.Media.Count != 0))
      {
        writer.WritePropertyName("media");
        writer.WriteStartArray();
        foreach (DiagnosticReport.MediaComponent val in current.Media)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ConclusionElement != null) && (current.ConclusionElement.Value != null))
      {
        writer.WriteString("conclusion",current.ConclusionElement.Value);
      }

      if ((current.ConclusionCode != null) && (current.ConclusionCode.Count != 0))
      {
        writer.WritePropertyName("conclusionCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ConclusionCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PresentedForm != null) && (current.PresentedForm.Count != 0))
      {
        writer.WritePropertyName("presentedForm");
        writer.WriteStartArray();
        foreach (Attachment val in current.PresentedForm)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DiagnosticReport
    /// </summary>
    public static void DeserializeJson(this DiagnosticReport current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DiagnosticReport
    /// </summary>
    public static void DeserializeJsonProperty(this DiagnosticReport current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
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

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>(reader.GetString()));

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

        case "encounter":
          current.Encounter = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "effectiveDateTime":
          current.Effective = new FhirDateTime(reader.GetString());
          break;

        case "effectivePeriod":
          current.Effective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
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

        case "resultsInterpreter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ResultsInterpreter = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ResultsInterpreter.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ResultsInterpreter.Count == 0)
          {
            current.ResultsInterpreter = null;
          }

          break;

        case "specimen":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Specimen = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Specimen.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Specimen.Count == 0)
          {
            current.Specimen = null;
          }

          break;

        case "result":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Result = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Result.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Result.Count == 0)
          {
            current.Result = null;
          }

          break;

        case "imagingStudy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ImagingStudy = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ImagingStudy.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ImagingStudy.Count == 0)
          {
            current.ImagingStudy = null;
          }

          break;

        case "media":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Media = new List<DiagnosticReport.MediaComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Media.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.DiagnosticReport.MediaComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Media.Count == 0)
          {
            current.Media = null;
          }

          break;

        case "conclusion":
          current.ConclusionElement = new FhirString(reader.GetString());

          break;

        case "conclusionCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ConclusionCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ConclusionCode.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ConclusionCode.Count == 0)
          {
            current.ConclusionCode = null;
          }

          break;

        case "presentedForm":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PresentedForm = new List<Attachment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.PresentedForm.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Attachment>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.PresentedForm.Count == 0)
          {
            current.PresentedForm = null;
          }

          break;

        // Complex: DiagnosticReport, Export: DiagnosticReport, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR DiagnosticReport#Media into JSON
    /// </summary>
    public static void SerializeJson(this DiagnosticReport.MediaComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: DiagnosticReport#Media, Export: MediaComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.CommentElement != null) && (current.CommentElement.Value != null))
      {
        writer.WriteString("comment",current.CommentElement.Value);
      }

      writer.WritePropertyName("link");
      current.Link.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DiagnosticReport#Media
    /// </summary>
    public static void DeserializeJson(this DiagnosticReport.MediaComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DiagnosticReport#Media
    /// </summary>
    public static void DeserializeJsonProperty(this DiagnosticReport.MediaComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "comment":
          current.CommentElement = new FhirString(reader.GetString());

          break;

        case "link":
          current.Link = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        // Complex: media, Export: MediaComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class DiagnosticReportJsonConverter : JsonConverter<DiagnosticReport>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(DiagnosticReport).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, DiagnosticReport value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override DiagnosticReport Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        DiagnosticReport target = new DiagnosticReport();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
