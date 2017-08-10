<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:param name="SenderID"></xsl:param>
	<xsl:param name="ReceiverID"></xsl:param>
	<xsl:param name="TransactionType"></xsl:param>
  <xsl:template match="/">
    <xsl:apply-templates select="/Interchange" />
  </xsl:template>
  <xsl:template match="/Interchange">
    <SenderID>
		<xsl:value-of select="$SenderID" />
    </SenderID>
	<ReceiverID>
		<xsl:value-of select="$ReceiverID" />
    </ReceiverID>
	<TransactionType>
		<xsl:value-of select="$TransactionType" />
    </TransactionType>
	<MapNumber>
		<xsl:text>1</xsl:text>
    </MapNumber>
  </xsl:template>
</xsl:stylesheet>