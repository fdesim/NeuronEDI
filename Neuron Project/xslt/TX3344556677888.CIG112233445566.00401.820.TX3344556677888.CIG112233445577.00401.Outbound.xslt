<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl userCSharp" version="1.0" xmlns:userCSharp="http://user">
	<xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
	<xsl:template match="/Transaction">
		<xsl:apply-templates select="/" />
	</xsl:template>
	<xsl:template match="/Transaction">
<Transaction>
			<ST>
				<ST01></ST01>
				<ST02></ST02>
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
					<xsl:value-of select="./Header/TraceTypeCode/text()" />
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
						<xsl:value-of select="./Payee/Name/text()" />
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
						<xsl:value-of select="./Payer/Name/text()" />
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
							<xsl:value-of select="./REFIDQual/text()" />
						</REF01>
						<REF02>
							<xsl:value-of select="./REFID/text()" />
						</REF02>
					</REF>
					<REF>
						<REF01>
							<xsl:value-of select="./REFIDQual2/text()" />
						</REF01>
						<REF02>
							<xsl:value-of select="./REFID2/text()" />
						</REF02>
					</REF>
					<REF>
						<REF01>
							<xsl:value-of select="./REFIDQual3/text()" />
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
			<SE>
				<SE01></SE01>
				<SE02></SE02>
			</SE>
	</Transaction>
	</xsl:template>

	<msxsl:script language="C#" implements-prefix="userCSharp">
						<![CDATA[
		public string getCurrentDate()
		{
		  return(DateTime.Now.ToString("MMddyy"));
		}
		public string getCurrentTime()
		{
			return(DateTime.Now.ToString("HHmm"));
		}
		public string htmlEscapeDecode(string value)
		{
			return System.Net.WebUtility.HtmlDecode(value);
		}
		public string padRight(string value, int padSpaces, string padChar)
		{
			return value.PadRight(padSpaces, System.Convert.ToChar(padChar));
		}
		public string padLeft(string value, int padSpaces, string padChar)
		{
			return value.PadLeft(padSpaces, System.Convert.ToChar(padChar));
		}
		]]>
	</msxsl:script>
</xsl:stylesheet>