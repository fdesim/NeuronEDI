<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
	<xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:param name="agreement"></xsl:param>
	<xsl:template match="/">
		<xsl:apply-templates select="/Agreement" />
	</xsl:template>
	<xsl:template match="/Agreement">
		<Execute>
			<xsl:attribute name="sp">
				<xsl:text>sp_Agreement_Configure</xsl:text>
            </xsl:attribute>
			<Parameters>
				<Parameter>
					<xsl:attribute name="name">
						<xsl:text>@agreement</xsl:text>
                    </xsl:attribute>
					<xsl:attribute name="value">
						<xsl:value-of select="$agreement" />
                    </xsl:attribute>
				</Parameter>
			</Parameters>
		</Execute>
	</xsl:template>
</xsl:stylesheet>