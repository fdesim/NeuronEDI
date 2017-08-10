<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
	<xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:param name="SenderID"></xsl:param>
	<xsl:param name="ReceiverID"></xsl:param>
	<xsl:param name="TransactionType"></xsl:param>
	<xsl:template match="/">
		<xsl:apply-templates select="/Transaction" />
		
	</xsl:template>
	<xsl:template match="/Transaction">
		<ASN>
			<xsl:choose>
				<xsl:when test="userCSharp:isBSN02Valid(./BSN/BSN02/text())">
   					<shipmentID>
						<xsl:value-of select="./BSN/BSN02/text()" />
                	</shipmentID>
				</xsl:when>
				<xsl:otherwise>
					<xsl:message terminate="yes">MAP VALIDATION ERROR ON BSN02</xsl:message>
                </xsl:otherwise>
			</xsl:choose>
			<shipmentDate>
				<xsl:value-of select="./BSN/BSN03" />
			</shipmentDate>
			<shipmentTime>
				<xsl:value-of select="./BSN/BSN04" />
			</shipmentTime>
			<!--Shipment-->
			<xsl:for-each select="./HierarchicalLoop">
				<Shipment>
					<shippedDate>
						<xsl:value-of select="./DTM/DTM02" />
					</shippedDate>
					<shipFrom>
						<xsl:value-of select="./Loop/N1[./N101='SF']/N102" />
					</shipFrom>
					<shipTo>
						<xsl:value-of select="./Loop/N1[./N101='ST']/N102" />
					</shipTo>
					<!--Order-->
					<xsl:for-each select="./HierarchicalLoop">
						<Order>
							<purchaseOrderNumber>
								<xsl:value-of select="./PRF/PRF01" />
							</purchaseOrderNumber>
							<!--Pack-->
							<xsl:for-each select="./HierarchicalLoop">
								<Pack>
									<trackingNumber><xsl:value-of select="./MAN/MAN02" /></trackingNumber>
									<!--Item-->
									<xsl:for-each select="./HierarchicalLoop">
										<Item>
											<productID><xsl:value-of select="./LIN/LIN03" /></productID>
											<xsl:for-each select="./SLN">
												<subLineID><xsl:value-of select="./SLN10" /></subLineID>
												<productDescription><xsl:value-of select="./SLN14" /></productDescription>
                                            </xsl:for-each>
                                        </Item>
									</xsl:for-each>
									<!--Item-->
								</Pack>
							</xsl:for-each>
							<!--Pack-->
						</Order>
					</xsl:for-each>
					<!--Order-->
				</Shipment>
			</xsl:for-each>
			<!--Shipment-->
		</ASN>
	</xsl:template>
	<msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public bool isBSN02Valid(string value)
{
  if(value.Length > 30)
		{
		  return false;
		}
  else
		{
		  return true;
		}
}

public void throwException(string message)
		{
		  throw new System.Xml.Xsl.XsltException(message);
		}

]]></msxsl:script>
</xsl:stylesheet>