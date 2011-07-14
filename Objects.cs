// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace eveobjects {
  
  public static partial class Objects {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_eveobjects_BooleanObject__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::eveobjects.BooleanObject, global::eveobjects.BooleanObject.Builder> internal__static_eveobjects_BooleanObject__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_eveobjects_functionCall__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::eveobjects.functionCall, global::eveobjects.functionCall.Builder> internal__static_eveobjects_functionCall__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_eveobjects_Interface__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::eveobjects.Interface, global::eveobjects.Interface.Builder> internal__static_eveobjects_Interface__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Objects() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Cg1vYmplY3RzLnByb3RvEgpldmVvYmplY3RzIh8KDUJvb2xlYW5PYmplY3QS" + 
          "DgoGaXN0cnVlGAEgAigIIkgKDGZ1bmN0aW9uQ2FsbBIMCgRuYW1lGAEgAigJ" + 
          "EhQKDHJlc3BvbnNldHlwZRgCIAIoCRIUCgxzdHJwYXJhbWV0ZXIYAyABKAki" + 
          "0gEKCUludGVyZmFjZRIMCgRuYW1lGAEgAigJEhAKCHRvcGxlZnRYGAIgAigF" + 
          "EhAKCHRvcGxlZnRZGAMgAigFEhYKDmhhc0Nsb3NlQnV0dG9uGAQgASgIEhUK" + 
          "DWNsb3NlVG9wTGVmdFgYBSABKAUSFQoNY2xvc2VUb3BMZWZ0WRgGIAEoBRIZ" + 
          "ChFoYXNDb250aW51ZUJ1dHRvbhgHIAEoCBIYChBjb250aW51ZVRvcExlZnRY" + 
          "GAggASgFEhgKEGNvbnRpbnVlVG9wTGVmdFkYCSABKAU=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_eveobjects_BooleanObject__Descriptor = Descriptor.MessageTypes[0];
        internal__static_eveobjects_BooleanObject__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::eveobjects.BooleanObject, global::eveobjects.BooleanObject.Builder>(internal__static_eveobjects_BooleanObject__Descriptor,
                new string[] { "Istrue", });
        internal__static_eveobjects_functionCall__Descriptor = Descriptor.MessageTypes[1];
        internal__static_eveobjects_functionCall__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::eveobjects.functionCall, global::eveobjects.functionCall.Builder>(internal__static_eveobjects_functionCall__Descriptor,
                new string[] { "Name", "Responsetype", "Strparameter", });
        internal__static_eveobjects_Interface__Descriptor = Descriptor.MessageTypes[2];
        internal__static_eveobjects_Interface__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::eveobjects.Interface, global::eveobjects.Interface.Builder>(internal__static_eveobjects_Interface__Descriptor,
                new string[] { "Name", "TopleftX", "TopleftY", "HasCloseButton", "CloseTopLeftX", "CloseTopLeftY", "HasContinueButton", "ContinueTopLeftX", "ContinueTopLeftY", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class BooleanObject : pb::GeneratedMessage<BooleanObject, BooleanObject.Builder> {
    private static readonly BooleanObject defaultInstance = new Builder().BuildPartial();
    public static BooleanObject DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override BooleanObject DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override BooleanObject ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::eveobjects.Objects.internal__static_eveobjects_BooleanObject__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<BooleanObject, BooleanObject.Builder> InternalFieldAccessors {
      get { return global::eveobjects.Objects.internal__static_eveobjects_BooleanObject__FieldAccessorTable; }
    }
    
    public const int IstrueFieldNumber = 1;
    private bool hasIstrue;
    private bool istrue_ = false;
    public bool HasIstrue {
      get { return hasIstrue; }
    }
    public bool Istrue {
      get { return istrue_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasIstrue) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasIstrue) {
        output.WriteBool(1, Istrue);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasIstrue) {
          size += pb::CodedOutputStream.ComputeBoolSize(1, Istrue);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static BooleanObject ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static BooleanObject ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static BooleanObject ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static BooleanObject ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static BooleanObject ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static BooleanObject ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static BooleanObject ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static BooleanObject ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static BooleanObject ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static BooleanObject ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(BooleanObject prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<BooleanObject, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      BooleanObject result = new BooleanObject();
      
      protected override BooleanObject MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new BooleanObject();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::eveobjects.BooleanObject.Descriptor; }
      }
      
      public override BooleanObject DefaultInstanceForType {
        get { return global::eveobjects.BooleanObject.DefaultInstance; }
      }
      
      public override BooleanObject BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        BooleanObject returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is BooleanObject) {
          return MergeFrom((BooleanObject) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(BooleanObject other) {
        if (other == global::eveobjects.BooleanObject.DefaultInstance) return this;
        if (other.HasIstrue) {
          Istrue = other.Istrue;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 8: {
              Istrue = input.ReadBool();
              break;
            }
          }
        }
      }
      
      
      public bool HasIstrue {
        get { return result.HasIstrue; }
      }
      public bool Istrue {
        get { return result.Istrue; }
        set { SetIstrue(value); }
      }
      public Builder SetIstrue(bool value) {
        result.hasIstrue = true;
        result.istrue_ = value;
        return this;
      }
      public Builder ClearIstrue() {
        result.hasIstrue = false;
        result.istrue_ = false;
        return this;
      }
    }
    static BooleanObject() {
      object.ReferenceEquals(global::eveobjects.Objects.Descriptor, null);
    }
  }
  
  public sealed partial class functionCall : pb::GeneratedMessage<functionCall, functionCall.Builder> {
    private static readonly functionCall defaultInstance = new Builder().BuildPartial();
    public static functionCall DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override functionCall DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override functionCall ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::eveobjects.Objects.internal__static_eveobjects_functionCall__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<functionCall, functionCall.Builder> InternalFieldAccessors {
      get { return global::eveobjects.Objects.internal__static_eveobjects_functionCall__FieldAccessorTable; }
    }
    
    public const int NameFieldNumber = 1;
    private bool hasName;
    private string name_ = "";
    public bool HasName {
      get { return hasName; }
    }
    public string Name {
      get { return name_; }
    }
    
    public const int ResponsetypeFieldNumber = 2;
    private bool hasResponsetype;
    private string responsetype_ = "";
    public bool HasResponsetype {
      get { return hasResponsetype; }
    }
    public string Responsetype {
      get { return responsetype_; }
    }
    
    public const int StrparameterFieldNumber = 3;
    private bool hasStrparameter;
    private string strparameter_ = "";
    public bool HasStrparameter {
      get { return hasStrparameter; }
    }
    public string Strparameter {
      get { return strparameter_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasName) return false;
        if (!hasResponsetype) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasName) {
        output.WriteString(1, Name);
      }
      if (HasResponsetype) {
        output.WriteString(2, Responsetype);
      }
      if (HasStrparameter) {
        output.WriteString(3, Strparameter);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasName) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Name);
        }
        if (HasResponsetype) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Responsetype);
        }
        if (HasStrparameter) {
          size += pb::CodedOutputStream.ComputeStringSize(3, Strparameter);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static functionCall ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static functionCall ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static functionCall ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static functionCall ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static functionCall ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static functionCall ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static functionCall ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static functionCall ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static functionCall ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static functionCall ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(functionCall prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<functionCall, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      functionCall result = new functionCall();
      
      protected override functionCall MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new functionCall();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::eveobjects.functionCall.Descriptor; }
      }
      
      public override functionCall DefaultInstanceForType {
        get { return global::eveobjects.functionCall.DefaultInstance; }
      }
      
      public override functionCall BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        functionCall returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is functionCall) {
          return MergeFrom((functionCall) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(functionCall other) {
        if (other == global::eveobjects.functionCall.DefaultInstance) return this;
        if (other.HasName) {
          Name = other.Name;
        }
        if (other.HasResponsetype) {
          Responsetype = other.Responsetype;
        }
        if (other.HasStrparameter) {
          Strparameter = other.Strparameter;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              Name = input.ReadString();
              break;
            }
            case 18: {
              Responsetype = input.ReadString();
              break;
            }
            case 26: {
              Strparameter = input.ReadString();
              break;
            }
          }
        }
      }
      
      
      public bool HasName {
        get { return result.HasName; }
      }
      public string Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder ClearName() {
        result.hasName = false;
        result.name_ = "";
        return this;
      }
      
      public bool HasResponsetype {
        get { return result.HasResponsetype; }
      }
      public string Responsetype {
        get { return result.Responsetype; }
        set { SetResponsetype(value); }
      }
      public Builder SetResponsetype(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasResponsetype = true;
        result.responsetype_ = value;
        return this;
      }
      public Builder ClearResponsetype() {
        result.hasResponsetype = false;
        result.responsetype_ = "";
        return this;
      }
      
      public bool HasStrparameter {
        get { return result.HasStrparameter; }
      }
      public string Strparameter {
        get { return result.Strparameter; }
        set { SetStrparameter(value); }
      }
      public Builder SetStrparameter(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasStrparameter = true;
        result.strparameter_ = value;
        return this;
      }
      public Builder ClearStrparameter() {
        result.hasStrparameter = false;
        result.strparameter_ = "";
        return this;
      }
    }
    static functionCall() {
      object.ReferenceEquals(global::eveobjects.Objects.Descriptor, null);
    }
  }
  
  public sealed partial class Interface : pb::GeneratedMessage<Interface, Interface.Builder> {
    private static readonly Interface defaultInstance = new Builder().BuildPartial();
    public static Interface DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Interface DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Interface ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::eveobjects.Objects.internal__static_eveobjects_Interface__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Interface, Interface.Builder> InternalFieldAccessors {
      get { return global::eveobjects.Objects.internal__static_eveobjects_Interface__FieldAccessorTable; }
    }
    
    public const int NameFieldNumber = 1;
    private bool hasName;
    private string name_ = "";
    public bool HasName {
      get { return hasName; }
    }
    public string Name {
      get { return name_; }
    }
    
    public const int TopleftXFieldNumber = 2;
    private bool hasTopleftX;
    private int topleftX_ = 0;
    public bool HasTopleftX {
      get { return hasTopleftX; }
    }
    public int TopleftX {
      get { return topleftX_; }
    }
    
    public const int TopleftYFieldNumber = 3;
    private bool hasTopleftY;
    private int topleftY_ = 0;
    public bool HasTopleftY {
      get { return hasTopleftY; }
    }
    public int TopleftY {
      get { return topleftY_; }
    }
    
    public const int HasCloseButtonFieldNumber = 4;
    private bool hasHasCloseButton;
    private bool hasCloseButton_ = false;
    public bool HasHasCloseButton {
      get { return hasHasCloseButton; }
    }
    public bool HasCloseButton {
      get { return hasCloseButton_; }
    }
    
    public const int CloseTopLeftXFieldNumber = 5;
    private bool hasCloseTopLeftX;
    private int closeTopLeftX_ = 0;
    public bool HasCloseTopLeftX {
      get { return hasCloseTopLeftX; }
    }
    public int CloseTopLeftX {
      get { return closeTopLeftX_; }
    }
    
    public const int CloseTopLeftYFieldNumber = 6;
    private bool hasCloseTopLeftY;
    private int closeTopLeftY_ = 0;
    public bool HasCloseTopLeftY {
      get { return hasCloseTopLeftY; }
    }
    public int CloseTopLeftY {
      get { return closeTopLeftY_; }
    }
    
    public const int HasContinueButtonFieldNumber = 7;
    private bool hasHasContinueButton;
    private bool hasContinueButton_ = false;
    public bool HasHasContinueButton {
      get { return hasHasContinueButton; }
    }
    public bool HasContinueButton {
      get { return hasContinueButton_; }
    }
    
    public const int ContinueTopLeftXFieldNumber = 8;
    private bool hasContinueTopLeftX;
    private int continueTopLeftX_ = 0;
    public bool HasContinueTopLeftX {
      get { return hasContinueTopLeftX; }
    }
    public int ContinueTopLeftX {
      get { return continueTopLeftX_; }
    }
    
    public const int ContinueTopLeftYFieldNumber = 9;
    private bool hasContinueTopLeftY;
    private int continueTopLeftY_ = 0;
    public bool HasContinueTopLeftY {
      get { return hasContinueTopLeftY; }
    }
    public int ContinueTopLeftY {
      get { return continueTopLeftY_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasName) return false;
        if (!hasTopleftX) return false;
        if (!hasTopleftY) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasName) {
        output.WriteString(1, Name);
      }
      if (HasTopleftX) {
        output.WriteInt32(2, TopleftX);
      }
      if (HasTopleftY) {
        output.WriteInt32(3, TopleftY);
      }
      if (HasHasCloseButton) {
        output.WriteBool(4, HasCloseButton);
      }
      if (HasCloseTopLeftX) {
        output.WriteInt32(5, CloseTopLeftX);
      }
      if (HasCloseTopLeftY) {
        output.WriteInt32(6, CloseTopLeftY);
      }
      if (HasHasContinueButton) {
        output.WriteBool(7, HasContinueButton);
      }
      if (HasContinueTopLeftX) {
        output.WriteInt32(8, ContinueTopLeftX);
      }
      if (HasContinueTopLeftY) {
        output.WriteInt32(9, ContinueTopLeftY);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasName) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Name);
        }
        if (HasTopleftX) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, TopleftX);
        }
        if (HasTopleftY) {
          size += pb::CodedOutputStream.ComputeInt32Size(3, TopleftY);
        }
        if (HasHasCloseButton) {
          size += pb::CodedOutputStream.ComputeBoolSize(4, HasCloseButton);
        }
        if (HasCloseTopLeftX) {
          size += pb::CodedOutputStream.ComputeInt32Size(5, CloseTopLeftX);
        }
        if (HasCloseTopLeftY) {
          size += pb::CodedOutputStream.ComputeInt32Size(6, CloseTopLeftY);
        }
        if (HasHasContinueButton) {
          size += pb::CodedOutputStream.ComputeBoolSize(7, HasContinueButton);
        }
        if (HasContinueTopLeftX) {
          size += pb::CodedOutputStream.ComputeInt32Size(8, ContinueTopLeftX);
        }
        if (HasContinueTopLeftY) {
          size += pb::CodedOutputStream.ComputeInt32Size(9, ContinueTopLeftY);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Interface ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Interface ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Interface ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Interface ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Interface ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Interface ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Interface ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Interface ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Interface ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Interface ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Interface prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Interface, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Interface result = new Interface();
      
      protected override Interface MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Interface();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::eveobjects.Interface.Descriptor; }
      }
      
      public override Interface DefaultInstanceForType {
        get { return global::eveobjects.Interface.DefaultInstance; }
      }
      
      public override Interface BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Interface returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Interface) {
          return MergeFrom((Interface) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Interface other) {
        if (other == global::eveobjects.Interface.DefaultInstance) return this;
        if (other.HasName) {
          Name = other.Name;
        }
        if (other.HasTopleftX) {
          TopleftX = other.TopleftX;
        }
        if (other.HasTopleftY) {
          TopleftY = other.TopleftY;
        }
        if (other.HasHasCloseButton) {
          HasCloseButton = other.HasCloseButton;
        }
        if (other.HasCloseTopLeftX) {
          CloseTopLeftX = other.CloseTopLeftX;
        }
        if (other.HasCloseTopLeftY) {
          CloseTopLeftY = other.CloseTopLeftY;
        }
        if (other.HasHasContinueButton) {
          HasContinueButton = other.HasContinueButton;
        }
        if (other.HasContinueTopLeftX) {
          ContinueTopLeftX = other.ContinueTopLeftX;
        }
        if (other.HasContinueTopLeftY) {
          ContinueTopLeftY = other.ContinueTopLeftY;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              Name = input.ReadString();
              break;
            }
            case 16: {
              TopleftX = input.ReadInt32();
              break;
            }
            case 24: {
              TopleftY = input.ReadInt32();
              break;
            }
            case 32: {
              HasCloseButton = input.ReadBool();
              break;
            }
            case 40: {
              CloseTopLeftX = input.ReadInt32();
              break;
            }
            case 48: {
              CloseTopLeftY = input.ReadInt32();
              break;
            }
            case 56: {
              HasContinueButton = input.ReadBool();
              break;
            }
            case 64: {
              ContinueTopLeftX = input.ReadInt32();
              break;
            }
            case 72: {
              ContinueTopLeftY = input.ReadInt32();
              break;
            }
          }
        }
      }
      
      
      public bool HasName {
        get { return result.HasName; }
      }
      public string Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder ClearName() {
        result.hasName = false;
        result.name_ = "";
        return this;
      }
      
      public bool HasTopleftX {
        get { return result.HasTopleftX; }
      }
      public int TopleftX {
        get { return result.TopleftX; }
        set { SetTopleftX(value); }
      }
      public Builder SetTopleftX(int value) {
        result.hasTopleftX = true;
        result.topleftX_ = value;
        return this;
      }
      public Builder ClearTopleftX() {
        result.hasTopleftX = false;
        result.topleftX_ = 0;
        return this;
      }
      
      public bool HasTopleftY {
        get { return result.HasTopleftY; }
      }
      public int TopleftY {
        get { return result.TopleftY; }
        set { SetTopleftY(value); }
      }
      public Builder SetTopleftY(int value) {
        result.hasTopleftY = true;
        result.topleftY_ = value;
        return this;
      }
      public Builder ClearTopleftY() {
        result.hasTopleftY = false;
        result.topleftY_ = 0;
        return this;
      }
      
      public bool HasHasCloseButton {
        get { return result.HasHasCloseButton; }
      }
      public bool HasCloseButton {
        get { return result.HasCloseButton; }
        set { SetHasCloseButton(value); }
      }
      public Builder SetHasCloseButton(bool value) {
        result.hasHasCloseButton = true;
        result.hasCloseButton_ = value;
        return this;
      }
      public Builder ClearHasCloseButton() {
        result.hasHasCloseButton = false;
        result.hasCloseButton_ = false;
        return this;
      }
      
      public bool HasCloseTopLeftX {
        get { return result.HasCloseTopLeftX; }
      }
      public int CloseTopLeftX {
        get { return result.CloseTopLeftX; }
        set { SetCloseTopLeftX(value); }
      }
      public Builder SetCloseTopLeftX(int value) {
        result.hasCloseTopLeftX = true;
        result.closeTopLeftX_ = value;
        return this;
      }
      public Builder ClearCloseTopLeftX() {
        result.hasCloseTopLeftX = false;
        result.closeTopLeftX_ = 0;
        return this;
      }
      
      public bool HasCloseTopLeftY {
        get { return result.HasCloseTopLeftY; }
      }
      public int CloseTopLeftY {
        get { return result.CloseTopLeftY; }
        set { SetCloseTopLeftY(value); }
      }
      public Builder SetCloseTopLeftY(int value) {
        result.hasCloseTopLeftY = true;
        result.closeTopLeftY_ = value;
        return this;
      }
      public Builder ClearCloseTopLeftY() {
        result.hasCloseTopLeftY = false;
        result.closeTopLeftY_ = 0;
        return this;
      }
      
      public bool HasHasContinueButton {
        get { return result.HasHasContinueButton; }
      }
      public bool HasContinueButton {
        get { return result.HasContinueButton; }
        set { SetHasContinueButton(value); }
      }
      public Builder SetHasContinueButton(bool value) {
        result.hasHasContinueButton = true;
        result.hasContinueButton_ = value;
        return this;
      }
      public Builder ClearHasContinueButton() {
        result.hasHasContinueButton = false;
        result.hasContinueButton_ = false;
        return this;
      }
      
      public bool HasContinueTopLeftX {
        get { return result.HasContinueTopLeftX; }
      }
      public int ContinueTopLeftX {
        get { return result.ContinueTopLeftX; }
        set { SetContinueTopLeftX(value); }
      }
      public Builder SetContinueTopLeftX(int value) {
        result.hasContinueTopLeftX = true;
        result.continueTopLeftX_ = value;
        return this;
      }
      public Builder ClearContinueTopLeftX() {
        result.hasContinueTopLeftX = false;
        result.continueTopLeftX_ = 0;
        return this;
      }
      
      public bool HasContinueTopLeftY {
        get { return result.HasContinueTopLeftY; }
      }
      public int ContinueTopLeftY {
        get { return result.ContinueTopLeftY; }
        set { SetContinueTopLeftY(value); }
      }
      public Builder SetContinueTopLeftY(int value) {
        result.hasContinueTopLeftY = true;
        result.continueTopLeftY_ = value;
        return this;
      }
      public Builder ClearContinueTopLeftY() {
        result.hasContinueTopLeftY = false;
        result.continueTopLeftY_ = 0;
        return this;
      }
    }
    static Interface() {
      object.ReferenceEquals(global::eveobjects.Objects.Descriptor, null);
    }
  }
  
  #endregion
  
}