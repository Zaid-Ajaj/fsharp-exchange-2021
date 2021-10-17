namespace rec CompanyData

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "Working">] Working
    | [<CompiledName "OnVacation">] OnVacation

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type fake__Locale =
    | [<CompiledName "az">] Az
    | [<CompiledName "cz">] Cz
    | [<CompiledName "de">] De
    | [<CompiledName "de_AT">] DeAt
    | [<CompiledName "de_CH">] DeCh
    | [<CompiledName "en">] En
    | [<CompiledName "en_AU">] EnAu
    | [<CompiledName "en_BORK">] EnBork
    | [<CompiledName "en_CA">] EnCa
    | [<CompiledName "en_GB">] EnGb
    | [<CompiledName "en_IE">] EnIe
    | [<CompiledName "en_IND">] EnInd
    | [<CompiledName "en_US">] EnUs
    | [<CompiledName "en_au_ocker">] EnAuOcker
    | [<CompiledName "es">] Es
    | [<CompiledName "es_MX">] EsMx
    | [<CompiledName "fa">] Fa
    | [<CompiledName "fr">] Fr
    | [<CompiledName "fr_CA">] FrCa
    | [<CompiledName "ge">] Ge
    | [<CompiledName "id_ID">] IdId
    | [<CompiledName "it">] It
    | [<CompiledName "ja">] Ja
    | [<CompiledName "ko">] Ko
    | [<CompiledName "nb_NO">] NbNo
    | [<CompiledName "nep">] Nep
    | [<CompiledName "nl">] Nl
    | [<CompiledName "pl">] Pl
    | [<CompiledName "pt_BR">] PtBr
    | [<CompiledName "ru">] Ru
    | [<CompiledName "sk">] Sk
    | [<CompiledName "sv">] Sv
    | [<CompiledName "tr">] Tr
    | [<CompiledName "uk">] Uk
    | [<CompiledName "vi">] Vi
    | [<CompiledName "zh_CN">] ZhCn
    | [<CompiledName "zh_TW">] ZhTw

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type fake__Types =
    | [<CompiledName "zipCode">] ZipCode
    | [<CompiledName "city">] City
    | [<CompiledName "streetName">] StreetName
    /// Configure address with option `useFullAddress`
    | [<CompiledName "streetAddress">] StreetAddress
    | [<CompiledName "secondaryAddress">] SecondaryAddress
    | [<CompiledName "county">] County
    | [<CompiledName "country">] Country
    | [<CompiledName "countryCode">] CountryCode
    | [<CompiledName "state">] State
    | [<CompiledName "stateAbbr">] StateAbbr
    | [<CompiledName "latitude">] Latitude
    | [<CompiledName "longitude">] Longitude
    | [<CompiledName "colorName">] ColorName
    | [<CompiledName "productCategory">] ProductCategory
    | [<CompiledName "productName">] ProductName
    /// Sum of money. Configure with options `minMoney`/`maxMoney` and 'decimalPlaces'.
    | [<CompiledName "money">] Money
    | [<CompiledName "productMaterial">] ProductMaterial
    | [<CompiledName "product">] Product
    | [<CompiledName "companyName">] CompanyName
    | [<CompiledName "companyCatchPhrase">] CompanyCatchPhrase
    | [<CompiledName "companyBS">] Company
    | [<CompiledName "dbColumn">] DbColumn
    | [<CompiledName "dbType">] DbType
    | [<CompiledName "dbCollation">] DbCollation
    | [<CompiledName "dbEngine">] DbEngine
    /// By default returns dates beetween 2000-01-01 and 2030-01-01.Configure date format with options `dateFormat` `dateFrom` `dateTo`.
    | [<CompiledName "date">] Date
    /// Configure date format with option `dateFormat`
    | [<CompiledName "pastDate">] PastDate
    /// Configure date format with option `dateFormat`
    | [<CompiledName "futureDate">] FutureDate
    /// Configure date format with option `dateFormat`
    | [<CompiledName "recentDate">] RecentDate
    | [<CompiledName "financeAccountName">] FinanceAccountName
    | [<CompiledName "financeTransactionType">] FinanceTransactionType
    | [<CompiledName "currencyCode">] CurrencyCode
    | [<CompiledName "currencyName">] CurrencyName
    | [<CompiledName "currencySymbol">] CurrencySymbol
    | [<CompiledName "bitcoinAddress">] BitcoinAddress
    | [<CompiledName "internationalBankAccountNumber">] InternationalBankAccountNumber
    | [<CompiledName "bankIdentifierCode">] BankIdentifierCode
    | [<CompiledName "hackerAbbreviation">] HackerAbbreviation
    | [<CompiledName "hackerPhrase">] HackerPhrase
    /// An image url. Configure image with options: `imageCategory`, `imageWidth`, `imageHeight` and `randomizeImageUrl`
    | [<CompiledName "imageUrl">] ImageUrl
    /// An URL for an avatar
    | [<CompiledName "avatarUrl">] AvatarUrl
    /// Configure email provider with option: `emailProvider`
    | [<CompiledName "email">] Email
    | [<CompiledName "url">] Url
    | [<CompiledName "domainName">] DomainName
    | [<CompiledName "ipv4Address">] Ipv4Address
    | [<CompiledName "ipv6Address">] Ipv6Address
    | [<CompiledName "userAgent">] UserAgent
    /// Configure color with option: `baseColor`
    | [<CompiledName "colorHex">] ColorHex
    | [<CompiledName "macAddress">] MacAddress
    /// Configure password with option `passwordLength`
    | [<CompiledName "password">] Password
    /// Lorem Ipsum text. Configure size with option `loremSize`
    | [<CompiledName "lorem">] Lorem
    | [<CompiledName "firstName">] FirstName
    | [<CompiledName "lastName">] LastName
    | [<CompiledName "fullName">] FullName
    | [<CompiledName "jobTitle">] JobTitle
    | [<CompiledName "phoneNumber">] PhoneNumber
    | [<CompiledName "number">] Number
    | [<CompiledName "uuid">] Uuid
    | [<CompiledName "word">] Word
    | [<CompiledName "words">] Words
    | [<CompiledName "locale">] Locale
    | [<CompiledName "filename">] Filename
    | [<CompiledName "mimeType">] MimeType
    | [<CompiledName "fileExtension">] FileExtension
    | [<CompiledName "semver">] Semver

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type fake__loremSize =
    | [<CompiledName "word">] Word
    | [<CompiledName "words">] Words
    | [<CompiledName "sentence">] Sentence
    | [<CompiledName "sentences">] Sentences
    | [<CompiledName "paragraph">] Paragraph
    | [<CompiledName "paragraphs">] Paragraphs

type fake__imageSize = { width: int; height: int }

type fake__color =
    { red255: Option<int>
      green255: Option<int>
      blue255: Option<int> }

type fake__options =
    { /// Only for type `streetAddress`
      useFullAddress: Option<bool>
      /// Only for type `money`
      minMoney: Option<float>
      /// Only for type `money`
      maxMoney: Option<float>
      /// Only for type `money`
      decimalPlaces: Option<int>
      /// Only for type `imageUrl`
      imageSize: Option<fake__imageSize>
      /// Only for type `imageUrl`. Example value: `["nature", "water"]`.
      imageKeywords: Option<list<string>>
      /// Only for type `imageUrl`
      randomizeImageUrl: Option<bool>
      /// Only for type `email`
      emailProvider: Option<string>
      /// Only for type `password`
      passwordLength: Option<int>
      /// Only for type `lorem`
      loremSize: Option<fake__loremSize>
      /// Only for types `*Date`. Example value: `YYYY MM DD`. [Full Specification](http://momentjs.com/docs/#/displaying/format/)
      dateFormat: Option<string>
      /// Only for types `betweenDate`. Example value: `1986-11-02`.
      dateFrom: Option<string>
      /// Only for types `betweenDate`. Example value: `2038-01-19`.
      dateTo: Option<string>
      /// Only for type `colorHex`. [Details here](https://stackoverflow.com/a/43235/4989887)
      baseColor: Option<fake__color>
      /// Only for type `number`
      minNumber: Option<float>
      /// Only for type `number`
      maxNumber: Option<float>
      /// Only for type `number`
      precisionNumber: Option<float> }

/// The error returned by the GraphQL backend
type ErrorType = { message: string }
