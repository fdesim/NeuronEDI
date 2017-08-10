<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:template match="/">
    	<xsl:apply-templates select="/Transaction" />
  	</xsl:template>
  	<xsl:template match="/Transaction">
		<xsl:if test="userCSharp:BEG01IsValid(./BEG/BEG01/text())"><TransactionSetPurposeCode><xsl:value-of select="./BEG/BEG01/text()" /></TransactionSetPurposeCode></xsl:if>
		<xsl:if test="userCSharp:BEG02IsValid(./BEG/BEG02/text())"><PurchaseOrderTypeCode><xsl:value-of select="./BEG/BEG02/text()" /></PurchaseOrderTypeCode></xsl:if>
	</xsl:template>
	<msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public bool BEG01IsValid(string value)
		{
			if(value == "00" || value == "03" || value == "05")
			{
				return true;
			}
			else
			{
				throw new System.Xml.Xsl.XsltException("850--Invalid BEG01 value: " + value + ".  Valid values are '00', '03', '05'.");
			}
		}
public bool BEG02IsValid(string value)
		{
			if(value == "IN" || value == "KN" || value == "NE")
			{
				return true;
			}
			else
			{
				throw new System.Xml.Xsl.XsltException("850--Invalid BEG02 value: " + value + ".  Valid values are 'IN', 'KN', 'NE'.");
			}
		}
public void throwException(string message)
{
	throw new System.Xml.Xsl.XsltException(message);
}
]]></msxsl:script>
</xsl:stylesheet>