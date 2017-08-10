<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:param name="SenderID"></xsl:param>
	<xsl:param name="ReceiverID"></xsl:param>
	<xsl:param name="Version"></xsl:param>
	<xsl:param name="TransactionType"></xsl:param>
	<xsl:param name="SenderGroup"></xsl:param>
	<xsl:param name="ReceiverGroup"></xsl:param>
	<xsl:param name="VersionGroup"></xsl:param>
  <xsl:template match="/">
    <xsl:apply-templates select="/Transaction" />
  </xsl:template>
  <xsl:template match="/Transaction">
	<MapOutput>
		<ST01>
			<xsl:value-of select="./ST/ST01" />
        </ST01>
	    <SenderID>
			<xsl:value-of select="$SenderID" />
	    </SenderID>
		<ReceiverID>
			<xsl:value-of select="$ReceiverID" />
	    </ReceiverID>
		<Version>
			<xsl:value-of select="$Version" />
	    </Version>
		<TransactionType>
			<xsl:value-of select="$TransactionType" />
	    </TransactionType>
		<SenderGroup>
			<xsl:value-of select="$SenderGroup" />
	    </SenderGroup>
		<ReceiverGroup>
			<xsl:value-of select="$ReceiverGroup" />
	    </ReceiverGroup>
		<VersionGroup>
			<xsl:value-of select="$VersionGroup" />
	    </VersionGroup>
	</MapOutput>
  </xsl:template>
</xsl:stylesheet>