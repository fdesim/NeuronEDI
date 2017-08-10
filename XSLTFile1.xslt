<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://user">
	<xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:template match="/">
		<xsl:apply-templates select="/OutboundX12" />
	</xsl:template>
	<xsl:template match="/OutboundX12">

		<xsl:variable name="NumSegments">0</xsl:variable>
		<Interchange>
			<xsl:attribute name="segment-terminator">
				<xsl:value-of select="userCSharp:htmlEscapeDecode(./Agreement/Row/Column[@name='SegmentSeparator']/text())" />
			</xsl:attribute>
			<xsl:attribute name="element-separator">
				<xsl:value-of select="userCSharp:htmlEscapeDecode(./Agreement/Row/Column[@name='ElementSeparator']/text())" />
			</xsl:attribute>
			<xsl:attribute name="sub-element-separator">
				<xsl:value-of select="userCSharp:htmlEscapeDecode(./Agreement/Row/Column[@name='ISA16SubElementSeparator']/text())" />
			</xsl:attribute>
			<ISA>
				<ISA01>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA01AuthorizationInformationQualifier']/text()" />
				</ISA01>
				<ISA02>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA02AuthorizationInformation']/text()" />
				</ISA02>
				<ISA03>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA03SecurityInformationQualifier']/text()" />
				</ISA03>
				<ISA04>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA04SecurityInformation']/text()" />
				</ISA04>
				<ISA05>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA05SenderInterchangeIDQualifier']/text()" />
				</ISA05>
				<ISA06>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA06SenderInterchangeID']/text()" />
				</ISA06>
				<ISA07>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA07ReceiverInterchangeIDQualifier']/text()" />
				</ISA07>
				<ISA08>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA08ReceiverInterchangeID']/text()" />
				</ISA08>
				<ISA09>
					<xsl:value-of select="userCSharp:getCurrentDate()" />
				</ISA09>
				<ISA10>
					<xsl:value-of select="userCSharp:getCurrentTime()" />
				</ISA10>
				<ISA11>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA11InterchangeStandardsID']/text()" />
				</ISA11>
				<ISA12>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA12InterchangeVersionID']/text()" />
				</ISA12>
				<ISA13>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA13InterchangeControlNumber']/text()" />
				</ISA13>
				<ISA14>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA14AckRequested']/text()" />
				</ISA14>
				<ISA15>
					<xsl:value-of select="./Agreement/Row/Column[@name='ISA15TestIndicator']/text()" />
				</ISA15>
				<ISA16>
					<xsl:value-of select="userCSharp:htmlEscapeDecode(./Agreement/Row/Column[@name='ISA16SubElementSeparator']/text())" />
				</ISA16>
			</ISA>
			<FunctionGroup>
				<GS>
					<GS01>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS01FunctionalIDCode']/text()" />
					</GS01>
					<GS02>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS02ApplicationSenderID']/text()" />
					</GS02>
					<GS03>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS03ApplicationReceiverID']/text()" />
					</GS03>
					<GS04>
						<xsl:value-of select="userCSharp:getCurrentDate()" />
					</GS04>
					<GS05>
						<xsl:value-of select="userCSharp:getCurrentTime()" />
					</GS05>
					<GS06>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS06GroupControlNumber']/text()" />
					</GS06>
					<GS07>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS07ResponsibleAgencyCode']/text()" />
					</GS07>
					<GS08>
						<xsl:value-of select="./Agreement/Row/Column[@name='GS08VersionReleaseIndustryIDCode']/text()" />
					</GS08>
				</GS>
				<xsl:for-each select="./RemittanceAdvice">
					<Transaction>
						<ST>
							<ST01>
								<xsl:value-of select="../Agreement/Row/Column[@name='TransactionType']/text()" />
							</ST01>
							<ST02>
								<xsl:value-of select="format-number(position(), '0000')" />
							</ST02>
							
						</ST>
						<BPR>
							<BPR01>
								<xsl:value-of select="./Header/TransactionHandlingCode/text()" />
							</BPR01>
							<BPR02>
								<xsl:value-of select="./Header/TotalPaymentAmount/text()" />
							</BPR02>
							<BPR03>
								<xsl:value-of select="./Header/CreditDebitFlagCode/text()" />
							</BPR03>
							<BPR04>
								<xsl:value-of select="./Header/PaymentMethodCode/text()" />
							</BPR04>
							<BPR05>
								<xsl:value-of select="./Header/PaymentFormatCode/text()" />
							</BPR05>
							<BPR06>
								<xsl:value-of select="./Header/PayerDFINumberQual/text()" />
							</BPR06>
							<BPR07>
								<xsl:value-of select="./Header/PayerDFINumber/text()" />
							</BPR07>
							<BPR08>
								<xsl:value-of select="./Header/PayerAccountNumberQual/text()" />
							</BPR08>
							<BPR09>
								<xsl:value-of select="./Header/PayerAccountNumber/text()" />
							</BPR09>
							<BPR10>
								<xsl:value-of select="./Header/OriginatingCompanyID/text()" />
							</BPR10>
							<BPR12>
								<xsl:value-of select="./Header/PayeeDFINumberQual/text()" />
							</BPR12>
							<BPR13>
								<xsl:value-of select="./Header/PayeeDFINumber/text()" />
							</BPR13>
							<BPR14>
								<xsl:value-of select="./Header/PayeeAccountNumberQual/text()" />
							</BPR14>
							<BPR15>
								<xsl:value-of select="./Header/PayeeAccountNumber/text()" />
							</BPR15>
							<BPR16>
								<xsl:value-of select="./Header/PaymentEffectiveDate/text()" />
							</BPR16>
						</BPR>
						<TRN>
							<TRN01>
								<xsl:value-of select="./Header/TraceNumberQual/text()" />
							</TRN01>
							<TRN02>
								<xsl:value-of select="./Header/TraceNumber/text()" />
							</TRN02>
						</TRN>
						<REF>
							<REF01>
								<xsl:value-of select="./Header/CheckNumberQual/text()" />
							</REF01>
							<REF02>
								<xsl:value-of select="./Header/CheckNumber/text()" />
							</REF02>
						</REF>
						<REF>
							<REF01>
								<xsl:value-of select="./Header/TransactionRefNumberQual/text()" />
							</REF01>
							<REF02>
								<xsl:value-of select="./Header/TransactionRefNumber/text()" />
							</REF02>
						</REF>
						<DTM>
							<DTM01>
								<xsl:text>007</xsl:text>
							</DTM01>
							<DTM02>
								<xsl:value-of select="./Header/PaymentEffectiveDate/text()" />
							</DTM02>
						</DTM>
						<Loop>
							<xsl:attribute name="LoopID">
								<xsl:text>N1</xsl:text>
							</xsl:attribute>
							<xsl:attribute name="Name">
								<xsl:text>Name</xsl:text>
							</xsl:attribute>
							<N1>
								<N101>
									<xsl:text>PE</xsl:text>
								</N101>
								<N102>
									<xsl:value-of select="./Header/Payee/Name/text()" />
								</N102>
							</N1>
						</Loop>
						<Loop>
							<xsl:attribute name="LoopID">
								<xsl:text>N1</xsl:text>
							</xsl:attribute>
							<xsl:attribute name="Name">
								<xsl:text>Name</xsl:text>
							</xsl:attribute>
							<N1>
								<N101>
									<xsl:text>PR</xsl:text>
								</N101>
								<N102>
									<xsl:value-of select="./Header/Payer/Name/text()" />
								</N102>
							</N1>
						</Loop>
						<xsl:for-each select="./Items/Item">
							<ENT>
								<ENT01>
									<xsl:value-of select="position()" />
								</ENT01>
							</ENT>
							<Loop>
								<xsl:attribute name="LoopID">
									<xsl:text>RMR</xsl:text>
								</xsl:attribute>
								<xsl:attribute name="Name">
									<xsl:text>Remittance Advice Accounts Receivable O</xsl:text>
								</xsl:attribute>
								<RMR>
									<RMR01>
										<xsl:value-of select="./RMRQual/text()" />
                                    </RMR01>
									<RMR02>
										<xsl:value-of select="./RMRID/text()" />
                                    </RMR02>
									<RMR04>
										<xsl:value-of select="./RMRAmount/text()" />
                                    </RMR04>
                                </RMR>
								<REF>
									<REF01>
										<xsl:value-of select="./REFID1Qual/text()" />
                                    </REF01>
									<REF02>
										<xsl:value-of select="./REFID1/text()" />
                                    </REF02>
									<REF03>
										<xsl:value-of select="./REFID1Desc/text()" />
                                    </REF03>
                                </REF>
								<REF>
									<REF01>
										<xsl:value-of select="./REFID2Qual/text()" />
                                    </REF01>
									<REF02>
										<xsl:value-of select="./REFID2/text()" />
                                    </REF02>
                                </REF>
								<REF>
									<REF01>
										<xsl:value-of select="./REFID3Qual/text()" />
                                    </REF01>
									<REF02>
										<xsl:value-of select="./REFID3/text()" />
                                    </REF02>
                                </REF>
								<DTM>
									<DTM01>
										<xsl:value-of select="./DTMQual/text()" />
                                    </DTM01>
									<DTM02>
										<xsl:value-of select="./DTM/text()" />
                                    </DTM02>
                                </DTM>
                            </Loop>
						</xsl:for-each>
						
					</Transaction>
					
				</xsl:for-each>
				
			</FunctionGroup>
			
		</Interchange>
		
	</xsl:template>
	
	<xsl:template match="/">
						<xsl:variable name="output">
							<xsl:apply-imports />
        				</xsl:variable>
						<count>
							<xsl:value-of select="userCSharp:segmentCount(msxsl:node-set($output))" />
                        </count>
							</xsl:template>
  
	<msxsl:script language="C#" implements-prefix="userCSharp">
    <!--<msxsl:assembly name="System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    <msxsl:assembly name="System.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
    <msxsl:using namespace="System.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />-->
		<![CDATA[
		public string getCurrentDate()
		{
		  return(DateTime.Now.ToString("yyyyMMdd"));
		}
		public string getCurrentTime()
		{
			return(DateTime.Now.ToString("HHmmss"));
		}
		public string htmlEscapeDecode(string value)
		{
			return System.Net.WebUtility.HtmlDecode(value);
		}
		public int segmentCount(XPathNavigator nav)
		{
      XPathNodeIterator iterator = nav.Select("//*");
			return iterator.Current.SelectChildren(XPathNodeType.All).Count;
		}
	]]>
</msxsl:script>
</xsl:stylesheet>