
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.posc.org/schemas", IsNullable = false)]
public partial class UnitOfMeasureDictionary
{

    private UnitOfMeasureDictionaryDocumentInformation documentInformationField;

    private UnitOfMeasureDictionaryUnitOfMeasure[] unitsDefinitionField;

    private decimal versionField;

    /// <remarks/>
    public UnitOfMeasureDictionaryDocumentInformation DocumentInformation
    {
        get
        {
            return this.documentInformationField;
        }
        set
        {
            this.documentInformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("UnitOfMeasure", IsNullable = false)]
    public UnitOfMeasureDictionaryUnitOfMeasure[] UnitsDefinition
    {
        get
        {
            return this.unitsDefinitionField;
        }
        set
        {
            this.unitsDefinitionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryDocumentInformation
{

    private UnitOfMeasureDictionaryDocumentInformationDocumentName documentNameField;

    private System.DateTime documentDateField;

    private UnitOfMeasureDictionaryDocumentInformationFileCreationInformation fileCreationInformationField;

    private string disclaimerField;

    private UnitOfMeasureDictionaryDocumentInformationEvent[] auditTrailField;

    private string dataOwnerIDField;

    private string commentField;

    /// <remarks/>
    public UnitOfMeasureDictionaryDocumentInformationDocumentName DocumentName
    {
        get
        {
            return this.documentNameField;
        }
        set
        {
            this.documentNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DocumentDate
    {
        get
        {
            return this.documentDateField;
        }
        set
        {
            this.documentDateField = value;
        }
    }

    /// <remarks/>
    public UnitOfMeasureDictionaryDocumentInformationFileCreationInformation FileCreationInformation
    {
        get
        {
            return this.fileCreationInformationField;
        }
        set
        {
            this.fileCreationInformationField = value;
        }
    }

    /// <remarks/>
    public string Disclaimer
    {
        get
        {
            return this.disclaimerField;
        }
        set
        {
            this.disclaimerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable = false)]
    public UnitOfMeasureDictionaryDocumentInformationEvent[] AuditTrail
    {
        get
        {
            return this.auditTrailField;
        }
        set
        {
            this.auditTrailField = value;
        }
    }

    /// <remarks/>
    public string DataOwnerID
    {
        get
        {
            return this.dataOwnerIDField;
        }
        set
        {
            this.dataOwnerIDField = value;
        }
    }

    /// <remarks/>
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryDocumentInformationDocumentName
{

    private string nameField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryDocumentInformationFileCreationInformation
{

    private System.DateTime fileCreationDateField;

    private string fileCreatorField;

    private string commentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FileCreationDate
    {
        get
        {
            return this.fileCreationDateField;
        }
        set
        {
            this.fileCreationDateField = value;
        }
    }

    /// <remarks/>
    public string FileCreator
    {
        get
        {
            return this.fileCreatorField;
        }
        set
        {
            this.fileCreatorField = value;
        }
    }

    /// <remarks/>
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryDocumentInformationEvent
{

    private System.DateTime eventDateField;

    private string responsiblePartyIDField;

    private string commentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime EventDate
    {
        get
        {
            return this.eventDateField;
        }
        set
        {
            this.eventDateField = value;
        }
    }

    /// <remarks/>
    public string ResponsiblePartyID
    {
        get
        {
            return this.responsiblePartyIDField;
        }
        set
        {
            this.responsiblePartyIDField = value;
        }
    }

    /// <remarks/>
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasure
{

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    private string idField;

    private string annotationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BaseUnit", typeof(UnitOfMeasureDictionaryUnitOfMeasureBaseUnit))]
    [System.Xml.Serialization.XmlElementAttribute("CatalogName", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CatalogSymbol", typeof(UnitOfMeasureDictionaryUnitOfMeasureCatalogSymbol))]
    [System.Xml.Serialization.XmlElementAttribute("ConversionToBaseUnit", typeof(UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit))]
    [System.Xml.Serialization.XmlElementAttribute("Deprecated", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("DimensionalClass", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("QuantityType", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SameUnit", typeof(UnitOfMeasureDictionaryUnitOfMeasureSameUnit))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string annotation
    {
        get
        {
            return this.annotationField;
        }
        set
        {
            this.annotationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureBaseUnit
{

    private string descriptionField;

    private string basicAuthorityField;

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public string BasicAuthority
    {
        get
        {
            return this.basicAuthorityField;
        }
        set
        {
            this.basicAuthorityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureCatalogSymbol
{

    private bool isExplicitField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isExplicit
    {
        get
        {
            return this.isExplicitField;
        }
        set
        {
            this.isExplicitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit
{

    private UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFormula formulaField;

    private UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFraction fractionField;

    private double factorField;

    private bool factorFieldSpecified;

    private string baseUnitField;

    /// <remarks/>
    public UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFormula Formula
    {
        get
        {
            return this.formulaField;
        }
        set
        {
            this.formulaField = value;
        }
    }

    /// <remarks/>
    public UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFraction Fraction
    {
        get
        {
            return this.fractionField;
        }
        set
        {
            this.fractionField = value;
        }
    }

    /// <remarks/>
    public double Factor
    {
        get
        {
            return this.factorField;
        }
        set
        {
            this.factorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FactorSpecified
    {
        get
        {
            return this.factorFieldSpecified;
        }
        set
        {
            this.factorFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string baseUnit
    {
        get
        {
            return this.baseUnitField;
        }
        set
        {
            this.baseUnitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFormula
{

    private decimal aField;

    private decimal bField;

    private decimal cField;

    private byte dField;

    /// <remarks/>
    public decimal A
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }

    /// <remarks/>
    public decimal B
    {
        get
        {
            return this.bField;
        }
        set
        {
            this.bField = value;
        }
    }

    /// <remarks/>
    public decimal C
    {
        get
        {
            return this.cField;
        }
        set
        {
            this.cField = value;
        }
    }

    /// <remarks/>
    public byte D
    {
        get
        {
            return this.dField;
        }
        set
        {
            this.dField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnitFraction
{

    private double numeratorField;

    private decimal denominatorField;

    /// <remarks/>
    public double Numerator
    {
        get
        {
            return this.numeratorField;
        }
        set
        {
            this.numeratorField = value;
        }
    }

    /// <remarks/>
    public decimal Denominator
    {
        get
        {
            return this.denominatorField;
        }
        set
        {
            this.denominatorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.posc.org/schemas")]
public partial class UnitOfMeasureDictionaryUnitOfMeasureSameUnit
{

    private string uomField;

    private string namingSystemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
        get
        {
            return this.uomField;
        }
        set
        {
            this.uomField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string namingSystem
    {
        get
        {
            return this.namingSystemField;
        }
        set
        {
            this.namingSystemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.posc.org/schemas", IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    BaseUnit,

    /// <remarks/>
    CatalogName,

    /// <remarks/>
    CatalogSymbol,

    /// <remarks/>
    ConversionToBaseUnit,

    /// <remarks/>
    Deprecated,

    /// <remarks/>
    DimensionalClass,

    /// <remarks/>
    Name,

    /// <remarks/>
    QuantityType,

    /// <remarks/>
    SameUnit,
}

