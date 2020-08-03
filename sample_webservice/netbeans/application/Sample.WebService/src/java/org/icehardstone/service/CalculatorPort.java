/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.icehardstone.service;

import javax.ws.rs.Consumes;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;

/**
 * REST Web Service
 *
 * @author admas
 */
@Path("calculatorport")
public class CalculatorPort {

    private org.icehardstone.service_client.Calculator port;

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of CalculatorPort
     */
    public CalculatorPort() {
        port = getPort();
    }

    /**
     * Invokes the SOAP method operation
     * @return an instance of java.lang.String
     */
    @GET
    @Produces("text/plain")
    @Consumes("text/plain")
    @Path("operation/")
    public String getOperation() {
        try {
            // Call Web Service Operation
            if (port != null) {
                java.lang.String result = port.operation();
                return result;
            }
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }

    /**
     * Invokes the SOAP method hello
     * @param name resource URI parameter
     * @return an instance of java.lang.String
     */
    @GET
    @Produces("text/plain")
    @Consumes("text/plain")
    @Path("hello/")
    public String getHello(@QueryParam("name") String name) {
        try {
            // Call Web Service Operation
            if (port != null) {
                java.lang.String result = port.hello(name);
                return result;
            }
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }

    /**
     *
     */
    private org.icehardstone.service_client.Calculator getPort() {
        try {
            // Call Web Service Operation
            org.icehardstone.service_client.Calculator_Service service = new org.icehardstone.service_client.Calculator_Service();
            org.icehardstone.service_client.Calculator p = service.getCalculatorPort();
            return p;
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }
}
